using Products_Web.Data.Entities;
using Products_Web.Models;
using Products_Web.Repositories;
using Products_Web.Repositories.Interfaces;
using Products_Web.Services.Interfaces;

namespace Products_Web.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Add(CreateProductViewModel product)
        {
            var productEntity = new Product(product.Name, product.Price, product.Stock);

            productRepository.Add(productEntity);
        }
    }
}
