using BusniessLogicLayer.DTOs;

namespace BusniessLogicLayer.Services
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDTO> GetAllDepartments();
        bool DeleteDepartment(int id); // Add this method to fix CS1061

        DepartmentDetailsDTO? GetDepartmentById(int id);
        bool AddDepartment(CreateDepartmentDTO departmentDTO);
        int UpdateDepartment(UpdatedDepartmentDto updatedDepartmentDto);
    }
}