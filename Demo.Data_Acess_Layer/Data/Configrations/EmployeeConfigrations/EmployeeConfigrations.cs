//using Demo.Data_Acess_Layer.Models.Employees;
//using Demo.Data_Acess_Layer.Models.Employees.Enums;
//using Microsoft.EntityFrameworkCore;
using Demo.Data_Acess_Layer.Models;
using Demo.Data_Acess_Layer.Models.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data_Acess_Layer.Data.Configrations
{
    internal class EmployeeConfigrations : BaseEntityConfigrations<Employees>,IEntityTypeConfiguration<Employees>
    {
        public new void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(50)");
            builder.Property(e => e.Salary).HasColumnType("decimal(10,2)");

            builder.Property(e => e.Gender).
                HasConversion((gender)=>gender.ToString(),
                               (ToGender)=> (Gender)Enum.Parse(typeof(Gender ),ToGender));


            builder.Property(e => e.EmployeeType).
                HasConversion((employeetype)=>employeetype.ToString(),
                               (toEmployee)=> (EmployeeType)Enum.Parse(typeof(EmployeeType),toEmployee));

            base.Configure(builder);
        }
    }
}
