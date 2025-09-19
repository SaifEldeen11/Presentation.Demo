using BusniessLogicLayer.DTOs.Employee;
using BusniessLogicLayer.Services.InterFaces;
using Demo.Data_Acess_Layer.Repostries.Employee.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Services.Classes
{
    public class EmployeeServices:IEmployeeServices
    {
        private readonly IEmployeeRepostiry _employeeRepostiry;

        public EmployeeServices(IEmployeeRepostiry employeeRepostiry)
        {
            _employeeRepostiry = employeeRepostiry;
        }
        public IEnumerable<EmployeeDto> GetAllEmployees(bool withTracking = false)
        {
            var employees = _employeeRepostiry.GetAll(withTracking);
            var EmployeesToReturn = employees.Select(e => new EmployeeDto()
            {
                Id = e.Id,
                Name = e.Name,
                Age = e.Age,
                Email = e.Email,
                IsActive= e.IsActive,
                Salary = e.Salary,
                Gender=e.Gender.ToString(),
                EmployeeType=e.EmployeeType.ToString()
            });
            return EmployeesToReturn;
        }
        public EmployeeDetailsDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepostiry.GetById(id);
            return employee is null ? null: new EmployeeDetailsDto()
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumeber=employee.PhoneNumber,
                HiringDate =DateOnly.FromDateTime(employee.HiringDate),
                IsActive = employee.IsActive,
                Gender=employee.Gender.ToString(),
                EmployeeType=employee.EmployeeType.ToString(),
                Salary = employee.Salary,
                CreatedBy= employee.CreatedBy,
                CreatedOn= employee.CreatedOn,
                LastModifiedBy= employee.LastModifiedBy,
                LastModifiedOn= employee.LastModifiedOn
            };
        }

        public int CreateEmployee(CreatedEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }



        public int UpdateEmployee(UpdatedEmployeeDto updatedEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
