using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;
namespace Biblioteca.DataBaseContext
{
    public class TestApeDB: DbContext
    {
        public TestApeDB(DbContextOptions options): base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Logins> Logins { get; set; }
    }
}
