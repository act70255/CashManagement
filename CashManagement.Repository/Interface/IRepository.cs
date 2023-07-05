using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> GetEntities();
        DbContext GetContext();
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Remove(TEntity entity);
        void SaveChanges();
    }
}
