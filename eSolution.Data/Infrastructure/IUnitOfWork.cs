namespace eSolution.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}