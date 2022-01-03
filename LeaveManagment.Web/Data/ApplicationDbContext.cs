using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; } // შექმნას დეითბეისი ჩემი კლასის მიხედვით.
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; } // შექმნას დეითბეისი ჩემი კლასის მიხედვით.

    }
}