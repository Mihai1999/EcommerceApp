
using DummyEcommApp.Common.Models;

namespace DummyEcommApp.Catalog.Models
{
	public class Category : BaseEntity<int>
	{
		public string Name { get; set; }

		public string ParentId { get; set; }

		public List<Product> Products { get; set; }

		public Category Parent { get; set; }

	}
}
