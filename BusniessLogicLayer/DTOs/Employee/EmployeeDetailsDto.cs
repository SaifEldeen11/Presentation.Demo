using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.DTOs.Employee
{
    public class EmployeeDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        public string? Email { get; set; }
        public string? PhoneNumeber { get; set; }
        public DateOnly HiringDate { get; set; }
        public string? Gender { get; set; }
        public string? EmployeeType { get; set; }
        
        public int CreatedBy { get; set; } // User_Id

        public DateTime? CreatedOn { get; set; } // Date

        public int LastModifiedBy { get; set; } // User_Id

        public DateTime? LastModifiedOn { get; set; } // Date
    }
}
