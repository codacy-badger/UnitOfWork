using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitOfWorl.Implementation.DomainEntities.Entities;

namespace UnitOfWork.Implementations.Infraestructure.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category", "dbo");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(128).IsRequired();

            builder.Property(e => e.Description).HasMaxLength(500);
        }
    }
}
