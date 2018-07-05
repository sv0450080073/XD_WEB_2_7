using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IUserGroupRepository
    { }

    public class UserGroupRepository:RepositoryBase<UserGroup>,IUserGroupRepository
    {
        public UserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}