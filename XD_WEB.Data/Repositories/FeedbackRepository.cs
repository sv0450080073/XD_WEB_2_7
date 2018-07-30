using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XD_WEB.Data.Infrastructure;
using XD_WEB.Model.Models;

namespace XD_WEB.Data.Repositories
{
    public interface IFeedbackRepository: IRepository<Feedback>
    {
    }
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {

        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        
    }
}
