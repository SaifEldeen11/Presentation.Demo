using BusniessLogicLayer.Services;
using Demo.Data_Acess_Layer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _departmentServices;
        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
        }
        public IActionResult Index()
        {
            var departmetns = _departmentServices.GetAllDepartments();
            return View();
        }
    }
}
