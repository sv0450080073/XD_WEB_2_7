using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig>
    { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository

    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}