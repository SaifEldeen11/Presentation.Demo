using Demo.Data_Acess_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Demo.Data_Acess_Layer.Data.Configrations
{
    public class BaseEntityConfigrations<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property("CreatedOn").HasDefaultValueSql("GetDate()");
            builder.Property("LastModifiedOn").HasComputedColumnSql("GetDate()");
        }
    }
}
