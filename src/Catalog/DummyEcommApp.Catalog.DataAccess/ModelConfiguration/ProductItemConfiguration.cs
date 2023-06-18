using DummyEcommApp.Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyEcommApp.Catalog.DataAccess.ModelConfiguration
{
	public class ProductItemConfiguration : IEntityTypeConfiguration<ProductItem>
	{
		public void Configure(EntityTypeBuilder<ProductItem> builder)
		{
			builder.ToTable("Catalog_ProductItems");
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Color).IsRequired().HasMaxLength(20);
			builder.Property(x => x.ReleaseDate).IsRequired();
		}
	}
}
