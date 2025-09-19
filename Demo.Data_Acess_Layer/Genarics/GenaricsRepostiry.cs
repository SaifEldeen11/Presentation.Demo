using Demo.Data_Acess_Layer.Data.Contexts;
using Demo.Data_Acess_Layer.Models;
using Demo.Data_Acess_Layer.Models.Department;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Genarics
{
    public class GenaricsRepostiry<TEntity>:IGenaricRepostiry<TEntity> where TEntity: BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public GenaricsRepostiry(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<TEntity> GetEnumerable()
        {
            return _dbContext.Set<TEntity>().Where(t => t.IsDeleted != true).ToList();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbContext.Set<TEntity>().Where(t => t.IsDeleted != true);
        }
        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _dbContext.Set<TEntity>().Where(t => t.IsDeleted != true).ToList();
            }
            else
            {
                return _dbContext.Set<TEntity>().Where(t => t.IsDeleted != true).AsNoTracking().ToList();
            }
        }
        // Update
        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChanges();
        }
        // Delete
        public int Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }
        // Insert
        public int Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }
        // Get By Id
        public TEntity? GetById(int id) 
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

    }
}
