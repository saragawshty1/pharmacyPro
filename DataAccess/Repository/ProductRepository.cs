using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class ProductRepository :Repository<Product> , IProductRepository
    {
        private readonly ApplicationDBContext context;
        public ProductRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
