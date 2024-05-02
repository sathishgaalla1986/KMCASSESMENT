using KMCASSESMENT.Models;
using KMCASSESMENT.Services;

namespace KMCASSESMENT.Infrastruture
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Product GetProductById(int id);
        List<Product> SearchProducts(string searchTerm);
    }
}
