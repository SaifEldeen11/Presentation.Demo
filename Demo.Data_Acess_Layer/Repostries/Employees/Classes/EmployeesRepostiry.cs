using Demo.Data_Acess_Layer.Data.Contexts;
using Demo.Data_Acess_Layer.Genarics;
using Demo.Data_Acess_Layer.Models.Department;
using Demo.Data_Acess_Layer.Models.Employee;
using Demo.Data_Acess_Layer.Repostries.Employee.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Repostries.Employee.Classes
{
    public class EmployeesRepostiry : GenaricsRepostiry<Employees>,IEmployeeRepostiry
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeesRepostiry(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
