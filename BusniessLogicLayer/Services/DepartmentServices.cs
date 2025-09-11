using BusniessLogicLayer.DTOs;
using BusniessLogicLayer.Factories;
using Demo.Data_Acess_Layer.Models;
using Demo.Data_Acess_Layer.Repostries;

namespace BusniessLogicLayer.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepostiry _departmentRepostiry;

        public DepartmentServices(IDepartmentRepostiry departmentRepostiry)
        {
            _departmentRepostiry = departmentRepostiry;
        }
        public IEnumerable<DepartmentDTO> GetAllDepartments()
        {
            var departments = _departmentRepostiry.GetAll();
            var DepartmentsToReturn = departments.Select(d => d.ToDepartmentDTO());
            return DepartmentsToReturn;
        }
        public DepartmentDetailsDTO? GetDepartmentById(int id)
        {
            var department = _departmentRepostiry.GetById(id);
            return department is null ? null : department.ToDepartmentDetailsDTO();
        }

        public int AddDepartment(CreateDepartmentDTO departmentDto)
        {
            return _departmentRepostiry.Insert(departmentDto.ToEntity());
        }

        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
        {
            return _departmentRepostiry.Update(departmentDto.ToEntity()); 
        }

        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepostiry.GetById(id);
            if(department is null)
            {
                return false;
            }
            else
            { 
              var result = _departmentRepostiry.Remove(department);
               return result > 0 ? true : false;
            }

        }
    }
}
