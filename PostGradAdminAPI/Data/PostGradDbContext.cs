using Microsoft.EntityFrameworkCore;
using PostGradAdminAPI.Models;

namespace PostGradAdminAPI.Data
{
    public class PostGradDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }


        public PostGradDbContext(DbContextOptions options) : base(options)
        {
        }



    }
}
