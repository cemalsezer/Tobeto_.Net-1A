using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("CategoryID").IsRequired(); 
            builder.Property(b => b.CategoryName).HasColumnName("CategoryName").IsRequired();
            builder.HasIndex(indexExpression: b => b.CategoryName, name: "UK_Categories_Name").IsUnique();
            builder.HasMany(b => b.Products);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
