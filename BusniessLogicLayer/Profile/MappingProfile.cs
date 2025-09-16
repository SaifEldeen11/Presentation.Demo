using BusniessLogicLayer.DTOs.EMP_DTOs;
using Demo.Data_Acess_Layer.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Profile
{
    internal class MappingProfile : AutoMapper.Profile
    {
        MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dist => dist.Gender, options => options.MapFrom(src => src.Gender))
                .ForMember(dist => dist.EmployeeType, options => options.MapFrom(src => src.EmployeeType));


        }
    }
}
