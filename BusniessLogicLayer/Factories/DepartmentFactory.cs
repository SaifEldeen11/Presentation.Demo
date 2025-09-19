using BusniessLogicLayer.DTOs;
using Demo.Data_Acess_Layer.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Factories
{
    static class DepartmentFactory
    {
        public static DepartmentDTO ToDepartmentDTO(this Department department)
        {

            return new DepartmentDTO()
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description ?? string.Empty,
                DateOfCreation = DateOnly.FromDateTime(department.CreatedOn ?? DateTime.Now),

            };
        }
        public static DepartmentDetailsDTO ToDepartmentDetailsDTO(this Department department)
        {
            return new DepartmentDetailsDTO
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreatedBy = department.CreatedBy,
                LastModifiedBy = department.LastModifiedBy,
                CreatedOn = DateOnly.FromDateTime(department.CreatedOn ?? DateTime.Now),
                IsDeleted = department.IsDeleted,
            };
        }

        public static Department ToEntity(this CreateDepartmentDTO departmentDTO)
        {
            return new Department
            {
                Code = departmentDTO.Code,
                Name = departmentDTO.Name,
                Description = departmentDTO.Description,
                CreatedOn = departmentDTO.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
        public static Department ToEntity(this UpdatedDepartmentDto departmentDTO)
        {
            return new Department
            {
                Id = departmentDTO.Id,
                Code = departmentDTO.Code,
                Name = departmentDTO.Name,
                Description = departmentDTO.Description,
                CreatedOn = departmentDTO.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
    }
}