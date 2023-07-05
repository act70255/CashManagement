using CashManagement.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Model
{
    public class LoginFormModel
    {
        IUserService _userService;
        public LoginFormModel(IUserService userService)
        {
            _userService = userService;
        }

        public LoginFormModel()
        {
        }

        public string Name { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }

        public bool CheckInput()
        {
            return !string.IsNullOrEmpty(Account) && !string.IsNullOrEmpty(Password);
        }
    }
}
