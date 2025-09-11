using Demo.Data_Acess_Layer.Data.Contexts;
using Demo.Data_Acess_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Repostries
{
    public class DepartmentRepostiry(ApplicationDbContext dbContext) : IDepartmentRepostiry
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        #region Dependancy Injection ctro [ hatwo w enta gy ]
        //public DepartmentRepostiry(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //} 
        #endregion

        // CRUD Operations
        // Get All 
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _dbContext.Departments.ToList();
            }
            else
            {
                return _dbContext.Departments.AsNoTracking().ToList();
            }
        }
        // Update
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
        // Delete
        public int Remove(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }
        // Insert
        public int Insert(Department department)
        {
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }
        // Get By Id
        public Department? GetById(int id)
        {
            return _dbContext.Departments.Find(id);
        }
    }
}
