using DummyEcommApp.Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DummyEcommApp.Catalog.DataAccess.ModelConfiguration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Catalog_Products");
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Brand).IsRequired().HasMaxLength(20);
			builder.Property(x => x.Model).IsRequired().HasMaxLength(20);
			builder.HasOne(x => x.Category)
				.WithMany(y => y.Products)
				.HasForeignKey(x => x.CategoryId);
		}
	}
}
