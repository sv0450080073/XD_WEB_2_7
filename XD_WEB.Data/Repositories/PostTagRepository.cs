using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}