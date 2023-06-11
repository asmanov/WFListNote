using Microsoft.EntityFrameworkCore;

namespace WFListNote
{
    public class MyDbContex : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PhoneBookDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
