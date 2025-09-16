using BusniessLogicLayer.DTOs.EMP_DTOs;
using Demo.Data_Acess_Layer.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Services.InterFaces
{
    public interface IEmplpoyeeService
    {
        IEnumerable<EmployeeDto> GetAllEmplyees(bool withTracking = false);
        EmployeeDetailsDto GetEmployeeById(int id);

        int CreateEmployee(CreatedEmployeeDTo createdEmployee);

        int UpdateEmployee(UpdatedEmployeeDto updatedEmployee);

        bool DeleteEmployee(int id);
    }
}
