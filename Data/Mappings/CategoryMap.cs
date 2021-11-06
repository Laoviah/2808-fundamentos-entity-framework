using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{

    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(80);
            
            builder.Property(x => x.Slug)
                   .IsRequired()
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(80);
            
            builder.HasIndex(x => x.Slug, "IX_CATEGORY_SLUG")
                   .IsUnique();
        }
    }
}