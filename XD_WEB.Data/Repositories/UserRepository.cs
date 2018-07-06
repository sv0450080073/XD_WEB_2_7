using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}