using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Demo.Data_Acess_Layer.Data.Configrations
{
    public class BaseEntityConfigrations<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property("CreatedOn").HasDefaultValueSql("GetDate()");
            builder.Property("LastModifiedOn").HasComputedColumnSql("GetDate()");
        }
    }
}
