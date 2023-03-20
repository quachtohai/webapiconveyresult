using System;

namespace eSolution.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        eSolutionDbContext Init();
    }
}