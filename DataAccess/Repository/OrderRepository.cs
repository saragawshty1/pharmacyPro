using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;
 

namespace DataAccess.Repository
{
    public class OrderRepository : Repository<Order> , IOrderRepository
    {
        private readonly ApplicationDBContext context;

        public OrderRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
