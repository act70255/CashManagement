using System;
using System.Collections.Generic;
using System.Text;
using CashManagement.Utility.Extension;
using CashManagement.Utility;

namespace CashManagement.Domain.Model
{
    public enum UserTypeEnum
    {
        [DisplayName("系統管理員")]
        Administrator = 0,
        [DisplayName("管理者")]
        Manager = 1,
        [DisplayName("一般用戶")]
        User = 2,
        [DisplayName("訪客")]
        Guest = 3,
    }
    public class UserModel : CashManagement.Entity.User
    {
        public Guid RoleID { get; set; }
        public UserModel()
        {
            RoleID = Guid.Empty;
            Enable = true;
            CreateTime = DateTime.Now;
        }

        public UserTypeEnum UserType { get; set; }
        public string RoleName { get; set; }

        public string ViewPassword { get { return _viewPassword; } set { _viewPassword = value; Password = value.GetMD5(); } }
        string _viewPassword;

        public bool CheckValidation()
        {
            if (string.IsNullOrEmpty(Account))
                throw new ArgumentNullException("缺少帳號");
            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("缺少密碼");
            return true;
        }
        public bool CheckSave()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("缺少姓名、帳號或密碼");
            if (RoleID == null || RoleID== Guid.Empty)
                throw new ArgumentNullException("缺少角色");
            return true;
        }

        public bool ValidPassword()
        {
            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("缺少密碼");

            return Password == ViewPassword.GetMD5();
        }
    }
}
