using HRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Data.Dbcontext
{
    public class HrmsDbcontext : DbContext
    {
        public HrmsDbcontext(DbContextOptions<HrmsDbcontext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    
}
