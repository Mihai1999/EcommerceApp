using DummyEcommApp.Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DummyEcommApp.Catalog.DataAccess.ModelConfiguration
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Catalog_Categories");
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
			builder.HasOne(x => x.Parent)
				.WithOne()
				.HasForeignKey<Category>(x => x.ParentId)
				.IsRequired(false);
		}
	}
}
