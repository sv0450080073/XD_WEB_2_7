namespace XD_WEB.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private XD_WEB_DBContext dbContext;

        public XD_WEB_DBContext Init()
        {
            return dbContext ?? (dbContext = new XD_WEB_DBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}