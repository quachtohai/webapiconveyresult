
using eSolution.ViewModels.Models.ConveyResults;
using System.Data.Entity;

namespace eSolution.Data
{
    public class eSolutionDbContext : DbContext
    {
        public eSolutionDbContext() : base("eSolutionConnection")
        {

        }
        public static eSolutionDbContext Create()
        {
            return new eSolutionDbContext();
        }
        public DbSet<Results> ConveyResults { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}
