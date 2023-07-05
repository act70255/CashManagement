using AutoMapper;
using CashManagement.Domain.Interface;
using CashManagement.Domain.Model;
using CashManagement.Entity;
using CashManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain
{
    public class RoleService : BaseService, IRoleService
    {
        IRepository<Role> _repository;

        public RoleService(IRepository<Role> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<RoleModel> GetAll()
        {
            return _mapper.Map<List<RoleModel>>(_repository.GetAll());
        }
    }
}
