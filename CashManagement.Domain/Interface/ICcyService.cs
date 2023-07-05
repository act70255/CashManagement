using CashManagement.Domain.Model;
using System.Collections.Generic;

namespace CashManagement.Domain.Interface
{
    public interface ICcyService
    {
        IEnumerable<CcyModel> GetAll();
        bool Update(CcyModel model);
        bool Insert(CcyModel model);
    }
}
