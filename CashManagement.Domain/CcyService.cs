using AutoMapper;
using CashManagement.Domain.Interface;
using CashManagement.Domain.Model;
using CashManagement.Repository;
using CashManagement.Entity;
using CashManagement.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CashManagement.Utility.Extension;

namespace CashManagement.Domain
{
    public class CcyService : BaseService, ICcyService
    {
        IRepository<ccy_base> _repository;
        public CcyService(IRepository<ccy_base> repository
            , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<CcyModel> GetAll()
        {
            var entities = _repository.GetAll();
            var models = _mapper.Map<IEnumerable<CcyModel>>(entities);
            return models;
        }

        public bool Insert(CcyModel model)
        {
            var entity = _mapper.Map<ccy_base>(model);
            //以下方法僅可作用在有設定PimaryKey的Table
            _repository.Insert(entity);
            return true;
        }

        public bool Update(CcyModel model)
        {
            Expression<Func<ccy_base, bool>> filter = f => true;
            filter = filter.AndAlso(f => f.ccy =="adsasd");

            var entityFiltered = _repository.GetEntities().Where(filter).ToList();
            var entity = _repository.GetEntities().FirstOrDefault(f => f.ccy == model.ccy);
            if (entity == null)
            {
                return false;//找不到可更新的資料
            }
            _mapper.Map(model, entity);
            _repository.SaveChanges();
            return true;
        }
    }
}
