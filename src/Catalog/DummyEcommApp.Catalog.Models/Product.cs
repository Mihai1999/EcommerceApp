using DummyEcommApp.Common.Models;

namespace DummyEcommApp.Catalog.Models
{
	public class Product : BaseEntity<Guid>
	{
		public string Brand { get; set; }

		public string Model { get; set; }

		public int CategoryId { get; set; }

		public Category Category { get; set; }
	}
}