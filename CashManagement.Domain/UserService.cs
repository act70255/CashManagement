using AutoMapper;
using CashManagement.Domain.Interface;
using CashManagement.Domain.Model;
using CashManagement.Entity;
using CashManagement.Repository.Interface;
using CashManagement.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain
{
    public class UserService : BaseService, IUserService
    {
        IRepository<User> _repository;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #region 驗證登入
        public UserModel Veladite(LoginFormModel model)
        {
            return Veladite(_mapper.Map<UserModel>(model));
        }

        public UserModel Veladite(UserModel model)
        {
            if (!model.CheckValidation())
                return null;
            var entityModel = _repository.GetEntities().Where(f => f.Account == model.Account && f.Enable == true)
                .Join(_repository.GetContext().Set<Role>(), u => u.RoleID, r => r.ID, (u, r) => new { u, r })
                .Select(s => new UserModel
                {
                    ID = s.u.ID,
                    Name = s.u.Name,
                    RoleID = s.u.RoleID.GetValueOrDefault(),
                    Password = s.u.Password,
                    Account = s.u.Account,
                    CreateTime = s.u.CreateTime,
                    RoleName = s.r.Name
                })
                .FirstOrDefault();

            if (entityModel == null)
                throw new Exception("帳號已停用或不存在");
            if (entityModel.Password != model.Password)
                throw new Exception("密碼錯誤");
            return entityModel;
        }
        #endregion

        public UserModel Register(UserModel model)
        {
            #region check input

            #endregion
            var entity = _mapper.Map<User>(model);
            _repository.Insert(entity);
            return Veladite(model);
        }

        public void InsertOrUpdate(UserModel model)
        {
            if (!model.CheckSave())
                return;

            if (model.ID == Guid.Empty)
            {
                model.ID = Guid.NewGuid();
                var entity = _mapper.Map<User>(model);
                entity.Password = model.Password; //加密密碼手動Mapping
                _repository.Insert(entity);
            }
            else
            {
                var entity = _repository.GetEntities().FirstOrDefault(f => f.ID == model.ID);
                _mapper.Map(model, entity);
                if(!string.IsNullOrEmpty(model.ViewPassword))
                    entity.Password = model.Password; //加密密碼手動Mapping
                _repository.SaveChanges();
            }
        }

        public bool Exist(string account)
        {
            return _repository.GetEntities().Any(a => a.Account == account);
        }

        public UserModel Get(Guid id)
        {
            var entity = _repository.GetEntities().FirstOrDefault(f => f.ID == id);
            return _mapper.Map<UserModel>(entity);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _repository.GetEntities()
                .Join(_repository.GetContext().Set<Role>(), u => u.RoleID, r => r.ID, (u, r) => new { u, r })
                .Select(s => new UserModel
                {
                    ID = s.u.ID,
                    Name = s.u.Name,
                    RoleID = s.u.RoleID.GetValueOrDefault(),
                    Password = s.u.Password,
                    Account = s.u.Account,
                    Enable = s.u.Enable,
                    CreateTime = s.u.CreateTime,
                    RoleName = s.r.Name
                }).ToList();
        }

        public void Delete(Guid id)
        {
            var entity = _repository.GetEntities().FirstOrDefault(f => f.ID == id);
            _repository.Delete(entity);
        }
    }
}
