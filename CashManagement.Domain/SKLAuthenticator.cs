using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using CashManagement.Domain.Model;
using CashManagement.Domain.Interface;
using AutoMapper;
using System;
using Blazored.LocalStorage;
using Microsoft.JSInterop;

namespace CashManagement.Domain
{
    public class SKLAuthenticator : AuthenticationStateProvider
    {
        IUserService _userService;
        IMapper _mapper;
        ILocalStorageService _storageService;

        public EventHandler OnLogin;

        public SKLAuthenticator(IUserService userService, IMapper mapper, ILocalStorageService storageService)
        {
            _userService = userService;
            _mapper = mapper;
            _storageService = storageService;
        }

        private Task<AuthenticationState> _authenticationStateTask;
        #region 驗證處理&驗證資料
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userJson = await _storageService.GetItemAsync<string>("User");
                var identity = GetClaimsIdentity(userJson);
                var user = new ClaimsPrincipal(identity);
                return new AuthenticationState(user);
            }
            catch (Exception ex)
            {
                return new AuthenticationState(new ClaimsPrincipal());
            }
        }

        ClaimsIdentity GetClaimsIdentity(string json)
        {
            return GetClaimsIdentity(Newtonsoft.Json.JsonConvert.DeserializeObject<UserModel>(json));
        }

        private ClaimsIdentity GetClaimsIdentity(UserModel user)
        {
            return new ClaimsIdentity(new Claim[]
            {
                new (ClaimTypes.Name, user.Name),
                new (ClaimTypes.Role, user.RoleName),
            }, "SKLAuth");
        }
        #endregion

        /// <summary>
        /// 開啟登入畫面
        /// </summary>
        public void RunLoginUI()
        {
            //觸發Page開啟登入介面
            OnLogin.Invoke(null, null);
        }

        public async Task<bool> Login(LoginFormModel model)
        {
            await Logout();
            var userModel = _mapper.Map<UserModel>(model);
            var loginUser = _userService.Veladite(userModel);

            if (loginUser != null)
            {
                await _storageService.SetItemAsync<string>("User", Newtonsoft.Json.JsonConvert.SerializeObject(loginUser));
                var identity = GetClaimsIdentity(loginUser);
                var principal = new ClaimsPrincipal(identity);
                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
                return true;
            }
            return false;
        }

        public async Task Logout()
        {
            await _storageService.ClearAsync();
            var principal = new ClaimsPrincipal();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
        }
    }
}