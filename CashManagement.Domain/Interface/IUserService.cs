using CashManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Interface
{
    public interface IUserService
    {
        public UserModel Veladite(LoginFormModel model);
        public UserModel Veladite(UserModel model);
        public UserModel Register(UserModel model);
        public bool Exist(string account);
        public UserModel Get(Guid id);
        public void InsertOrUpdate(UserModel model);
        public void Delete(Guid id);
        public IEnumerable<UserModel> GetAll();
    }
}
