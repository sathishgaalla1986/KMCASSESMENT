using KMCASSESMENT.Models;

namespace KMCASSESMENT.Infrastruture
{
    public interface IOrderService
    {
        void PlaceOrder(int productId, string customerName);
        List<Order> GetAllOrders();
        List<Order> GetOrdersByCustomer(string customerName);
    }
}
