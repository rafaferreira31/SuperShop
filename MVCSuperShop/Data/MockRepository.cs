using MVCSuperShop.Data.Entities;

namespace MVCSuperShop.Data
{
    public class MockRepository : IRepository
    {
        void IRepository.AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Product IRepository.GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository.GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Teste1", Price = 10});
            products.Add(new Product { Id = 2, Name = "Teste2", Price = 20 });
            products.Add(new Product { Id = 3, Name = "Teste3", Price = 30 });
            products.Add(new Product { Id = 4, Name = "Teste4", Price = 40 });
            products.Add(new Product { Id = 5, Name = "Teste5", Price = 50 });

            return products;

        }

        bool IRepository.ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository.RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository.SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        void IRepository.UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
