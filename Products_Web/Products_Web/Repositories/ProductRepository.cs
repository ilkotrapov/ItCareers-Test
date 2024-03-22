using Products_Web.Data;
using Products_Web.Data.Entities;
using Products_Web.Repositories.Interfaces;

namespace Products_Web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext context;

        public ProductRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
