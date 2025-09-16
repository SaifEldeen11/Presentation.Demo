﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.DTOs.Departments
{
    public class UpdatedDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; }= null!;
        public string? Description { get; set; }

        public DateOnly DateOfCreation { get; set; }
    }
}
