using AutoMapper;
using BusniessLogicLayer.DTOs.Employee;
using BusniessLogicLayer.Services.InterFaces;
using Demo.Data_Acess_Layer.Models.Employee;
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
        private readonly IMapper _mapper;

        public EmployeeServices(IEmployeeRepostiry employeeRepostiry,IMapper mapper)
        {
            _employeeRepostiry = employeeRepostiry;
            _mapper = mapper;
        }
        public IEnumerable<EmployeeDto> GetAllEmployees(bool withTracking = false)
        {
            //var employees = _employeeRepostiry.GetAll(withTracking);
            var employees = _employeeRepostiry.GetEnumerable();
            var employeesToReturn = employees.Select(e => new EmployeeDto()
            {
                Name = e.Name,
                Age = e.Age,
                Email=e.Email
            });
            // Tsource => src => employee
            // TDestination => dest => EmployeeDto  
            //var employeesToReturn = _mapper.Map<IEnumerable<Employees>, IEnumerable<EmployeeDto>>(employees);




            return employeesToReturn;
        }
        public EmployeeDetailsDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepostiry.GetById(id);
            return employee is null ? null: _mapper.Map<Employees, EmployeeDetailsDto>(employee);
        }

        public int CreateEmployee(CreatedEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<CreatedEmployeeDto, Employees>(employeeDto);
            return _employeeRepostiry.Insert(employee);
        }
        public int UpdateEmployee(UpdatedEmployeeDto updatedEmployee)
        {
            return _employeeRepostiry.Update(_mapper.Map<UpdatedEmployeeDto, Employees>(updatedEmployee));
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _employeeRepostiry.GetById(id);
            if (employee is null)
            {
                return false;
            }
            employee.IsDeleted = true;
           var result = _employeeRepostiry.Update(employee);
            return result > 0;

            #region Hard Deleted
            //var result = _employeeRepostiry.Remove(employee);

            //return result > 0; 
            #endregion
        }



    }
}
