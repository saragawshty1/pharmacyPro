using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class ShoppingCartRepository :Repository<ShoppingCart> , IShoppingCartRepository
    {
        private readonly ApplicationDBContext context;

        public ShoppingCartRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
