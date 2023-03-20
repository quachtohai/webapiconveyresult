namespace eSolution.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private eSolutionDbContext dbContext;

        public eSolutionDbContext Init()
        {
            return dbContext ?? (dbContext = new eSolutionDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}