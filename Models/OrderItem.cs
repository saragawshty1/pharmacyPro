namespace Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public decimal? cost { get; set; }
        public int? count { get; set; }
        public Product? Product { get; set; }
        public Device? Device { get; set; }
        public int ? DeviceID { get; set; }
    }
}
