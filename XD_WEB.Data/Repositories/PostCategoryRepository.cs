using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IPostCateRepository
    { }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCateRepository

    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}