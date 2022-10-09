using Microsoft.EntityFrameworkCore;
using WebAPIKatherine.Models;

namespace WebAPIKatherine.Data
{
    public class IssueDbContext: DbContext 
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        { }
        public DbSet<Issue> Issues { get; set; }
    }
}
