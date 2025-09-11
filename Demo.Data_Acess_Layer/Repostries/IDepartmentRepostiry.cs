using Demo.Data_Acess_Layer.Models;

namespace Demo.Data_Acess_Layer.Repostries
{
    public interface IDepartmentRepostiry
    {
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        int Insert(Department department);
        int Remove(Department department);
        int Update(Department department);
    }
}