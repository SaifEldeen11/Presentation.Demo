using Demo.Data_Acess_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.DTOs
{
    public class DepartmentDetailsDTO
    {
        //public DepartmentDetailsDTO(Department department)
        //{
        //    Id = department.Id;
        //    Name = department.Name;
        //    Code = department.Code;
        //    Description = department.Description;
        //    CreatedBy = department.CreatedBy;
        //    LastModifiedBy = department.LastModifiedBy;
        //    CreatedOn = DateOnly.FromDateTime(department.CreatedOn ?? DateTime.Now);
        //    IsDeleted = department.IsDeleted;
        //}

        public int Id { get; set; } 
        public string Name { get; set; } = null!;

        public string Code { get; set; } = null!;
        public string? Description { get; set; } = string.Empty;

        public int CreatedBy { get; set; } 

        public DateOnly? CreatedOn { get; set; } 

        public int LastModifiedBy { get; set; } 
        public bool IsDeleted { get; set; }

    }
}
