using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface ICredentialRepository : IRepository<Credential>
    { }

    public class CredentialRepository : RepositoryBase<Credential>, ICredentialRepository
    {
        public CredentialRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}