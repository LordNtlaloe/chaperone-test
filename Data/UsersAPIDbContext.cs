using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class UsersAPIDbContext : DbContext
    {
        public UsersAPIDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<Users> Users { get; set; }
    }
}
