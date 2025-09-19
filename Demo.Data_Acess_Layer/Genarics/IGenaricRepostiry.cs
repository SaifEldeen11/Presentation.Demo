using Demo.Data_Acess_Layer.Models;
using Demo.Data_Acess_Layer.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Genarics
{
    public interface IGenaricRepostiry<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        TEntity? GetById(int id);
        IEnumerable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);

        int Insert(TEntity department);
        int Remove(TEntity department);
        int Update(TEntity department);
    }
}
