using DataAccess;
using  Models;
using DataAccess.Repository.IRepository;
 

namespace DataAccess.Repository
{
    public class CommentRepository :Repository<Comment> , ICommentRepository
    {
        private readonly ApplicationDBContext context;
        public CommentRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
