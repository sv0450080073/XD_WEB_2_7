using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository

    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}