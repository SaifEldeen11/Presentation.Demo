using Demo.Data_Acess_Layer.Models.Employees;
using Demo.Data_Acess_Layer.Models.Employees.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Data.Configrations
{
    internal class EmployeeConfigrations : BaseEntityConfigrations<Employee>,IEntityTypeConfiguration<Employee>
    {
        public new void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(e => e.Gender).
                HasConversion(gender => gender.ToString(),toGender => (Gender)Enum.Parse(typeof(Gender),toGender));
            builder.Property(e => e.EmployeeType).
                HasConversion(EmployeeType => EmployeeType.ToString(), ToEmployeeType => (EmployeeType)Enum.Parse(typeof(EmployeeType), ToEmployeeType));


        }
    }
}
