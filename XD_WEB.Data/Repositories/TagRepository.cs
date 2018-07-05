using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface ITagRepository
    { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository

    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}