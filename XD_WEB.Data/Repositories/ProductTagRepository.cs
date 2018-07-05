using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IProductTagRepository
    { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository

    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}