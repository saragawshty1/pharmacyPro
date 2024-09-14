using DataAccess;
using Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class PostRepository : Repository<Post> , IPostRepository 
    {
        private readonly ApplicationDBContext context;

        public PostRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
