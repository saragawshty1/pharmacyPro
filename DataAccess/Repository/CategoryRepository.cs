using DataAccess.Repository;
using Models;
using DataAccess.Repository.IRepository;
 

namespace DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext context;
        public CategoryRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
