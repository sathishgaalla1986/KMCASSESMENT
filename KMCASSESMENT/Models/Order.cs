namespace KMCASSESMENT.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
