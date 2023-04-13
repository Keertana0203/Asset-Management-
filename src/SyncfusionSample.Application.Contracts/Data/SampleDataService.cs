using System;
using System.Collections.Generic;
using System.Linq;
using SyncfusionSample.Products;
using Volo.Abp.DependencyInjection;

namespace SyncfusionSample.Data
{
	public class SampleDataService : ISingletonDependency
	{
		private List<ProductDto> DataSource = new List<ProductDto>
		{
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Dell XPS 15 Laptop",
                Description=" Intel Core i7 processor, spacious SSD storage, a 15.6-inch FHD display with narrow bezels, and premium aluminum chassis design.",
                Price = 78.50F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Steelcase Leap Office Chair",
                Description="Optimal support with a breathable mesh back, adjustable lumbar support, and multiple seat adjustments for height, tilt, and armrests.",
                Price = 20.99F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Projector",
                Description=" Full HD resolution and vibrant colors, with easy connectivity options such as HDMI and USB for hassle-free setup.",
                Price = 33.79F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Logitech Rally Plus Conference Camera",
                Description="Offers advanced video and audio performance for professional meetings, with 4K Ultra HD video, modular audio components, and versatile mounting options.",
                Price = 30.85F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Notes and Dispenser",
                Description="Sleek design, easy dispensing of sticky notes, and a built-in pen holder for convenience.",
                Price = 10.23F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Wooden table",
                Description="Sustainable wood, featuring a sturdy construction, a spacious surface for work or dining, and a timeless design that complements any decor.",
                Price = 40.23F
            },
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Digital white board",
                Description="Touch-enabled technology, seamless integration with digital devices, and intuitive software for brainstorming, presentations, and remote collaboration.",
                Price = 10.23F
            },

        };

		public List<ProductDto> GetProducts()
		{
			return DataSource;
		}

		public ProductDto GetProduct(Guid id)
		{
			return DataSource.SingleOrDefault(x => x.Id == id);
		}

		public ProductDto CreateProduct(ProductDto input)
		{
			DataSource.Add(new ProductDto
			{
				Id = input.Id,
				Name = input.Name,
				Description = input.Description,
				Price = input.Price,
				
			});

			return input;
		}

		public ProductDto UpdateProduct(ProductDto input)
		{
			DeleteProduct(input);
			CreateProduct(input);

			return input;
		}

		public void DeleteProduct(ProductDto input)
		{
			DataSource.Remove(input);
		}
	}
}