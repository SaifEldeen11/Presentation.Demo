using BusniessLogicLayer.DTOs.Departments;

namespace BusniessLogicLayer.Services.InterFaces
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDTO> GetAllDepartments();
        DepartmentDetailsDTO? GetDepartmentById(int id);
    }
}