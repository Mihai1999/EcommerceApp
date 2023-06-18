using DummyEcommApp.Common.Models;

namespace DummyEcommApp.Catalog.Models
{
	public class ProductItem : BaseEntity<Guid>
	{
		public string Color { get; set; }

		public decimal Price { get; set; }

		public DateTimeOffset ReleaseDate { get; set; }
	}
}
