using CashManagement.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashManagement.Repository
{
    public class Repository<TEntity> : BaseRepository, IRepository<TEntity> where TEntity : class
    {
        #region property
        protected DbSet<TEntity> entities { get; set; }
        #endregion

        #region Constructor
        public Repository(Entity.Test_BlazorContext _dbContext)
        {
            dbContext = _dbContext;
            entities = dbContext.Set<TEntity>();
        }
        #endregion

        public DbSet<TEntity> GetEntities()
        {
            return entities;
        }

        public DbContext GetContext()
        {
            return dbContext;
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("null entity");
            }
            entities.Remove(entity);

            dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            dbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
