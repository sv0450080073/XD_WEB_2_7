using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_WEB.Data.Infrastructure
{
    interface IUnitOfWork
    {
        void Commit();
    }
}
