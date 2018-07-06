using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}