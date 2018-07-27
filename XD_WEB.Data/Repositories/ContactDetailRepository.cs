using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IContactDetailRepository:IRepository<ContactDetail>
    {
    }

    public class ContactDetailRepository: RepositoryBase<ContactDetail>, IContactDetailRepository
    {

        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
