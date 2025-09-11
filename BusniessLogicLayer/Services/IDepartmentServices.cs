using BusniessLogicLayer.DTOs;

namespace BusniessLogicLayer.Services
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDTO> GetAllDepartments();
        DepartmentDetailsDTO? GetDepartmentById(int id);
    }
}