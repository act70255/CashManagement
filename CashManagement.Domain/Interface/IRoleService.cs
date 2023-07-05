using CashManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Interface
{
    public interface IRoleService
    {
        public IEnumerable<RoleModel> GetAll();
    }
}
