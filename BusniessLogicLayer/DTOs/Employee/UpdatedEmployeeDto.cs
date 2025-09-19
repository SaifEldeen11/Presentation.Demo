using Demo.Data_Acess_Layer.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.DTOs.Employee
{
    public class UpdatedEmployeeDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name must be less than 50 chars")]
        [MinLength(3, ErrorMessage = "Name Should be at least 3 chars")]
        public string Name { get; set; } = null!;
        [Range(24, 40)]
        public int Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [Display(Name = "Hiring Date")]
        public DateOnly HiringDate { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        // 123-Street-City-Country
        [RegularExpression("^[1-9]{1,3}-[a-zA-z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
         ErrorMessage = "Adress Must be in this format:123-Street-City-Country ")]
        public string? Adress { get; set; }
        [Display(Name = "Phone Number ")]
        public string? PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
