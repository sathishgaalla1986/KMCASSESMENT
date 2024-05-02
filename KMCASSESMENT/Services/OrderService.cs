using KMCASSESMENT.Infrastruture;
using KMCASSESMENT.Models;

namespace KMCASSESMENT.Services
{
    public class OrderService: IOrderService
    {
        private List<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>();
        }

        public void PlaceOrder(int productId, string customerName)
        {
            // In a real application, you would typically perform additional validations and handle order processing logic here.
            var order = new Order
            {
                Id = _orders.Count + 1,
                ProductId = productId,
                CustomerName = customerName,
                OrderDate = DateTime.UtcNow
            };
            _orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        public List<Order> GetOrdersByCustomer(string customerName)
        {
            return _orders.Where(o => o.CustomerName == customerName).ToList();
        }
    }
}
