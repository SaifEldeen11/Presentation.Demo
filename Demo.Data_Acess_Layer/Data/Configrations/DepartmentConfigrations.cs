using Demo.Data_Acess_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Data.Configrations
{
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.Code).HasColumnType("varchar(20)");
            builder.Property(d => d.CreatedOn).HasDefaultValueSql("GetDate()"); // First Time Only 
            builder.Property(d => d.LastModifiedOn).HasComputedColumnSql("GetDate()"); // for insert and update

        }
    }
}
