using Demo.Data_Acess_Layer.Data.Contexts;
using Demo.Data_Acess_Layer.Genarics;
using Demo.Data_Acess_Layer.Models.Department;
using Demo.Data_Acess_Layer.Repostries.Departments.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Repostries.Departments.Classes
{
    public class DepartmentRepostiry:GenaricsRepostiry<Department>, IDepartmentRepostiry
    {
        private readonly ApplicationDbContext _dbContext;

        #region Dependancy Injection ctro [ hatwo w enta gy ]
        public DepartmentRepostiry(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        // CRUD Operations
        // Get All 
    }
}