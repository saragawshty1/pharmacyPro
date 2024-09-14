//using pharmacy.Data.Enum;

using Utility;

namespace  Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int? PatientID { get; set; }
        public Patient? Patients { get; set; }
       public DateTime? orderDate { get; set; }
        public decimal? totalprice { get; set; }
        public DeliveryTypes? DeliveryTpe { get; set; }
        public int? OrderStatusID { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
