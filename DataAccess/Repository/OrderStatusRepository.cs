using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class OrderStatusRepository :Repository<OrderStatus> , IOrderStatusRepository
    {
        private readonly ApplicationDBContext context;
        public OrderStatusRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
