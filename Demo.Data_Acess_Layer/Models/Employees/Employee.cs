using Demo.Data_Acess_Layer.Models.Employees.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Models.Employees
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public bool IsActive { get; set; }
        public string Adress { get; set; } = null!;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public DateTime HirringDate { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Gender Gender { get; set; }

    }
}
