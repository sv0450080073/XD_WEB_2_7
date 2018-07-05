using System;

namespace XD_WEB.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        XD_WEB_DBContext Init();
    }
}