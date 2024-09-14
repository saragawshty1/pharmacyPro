using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;
 

namespace DataAccess.Repository
{
    public class OrderItemRepository : Repository<OrderItem> , IOrderItemRepository
    {
        private readonly ApplicationDBContext context;

        public OrderItemRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
