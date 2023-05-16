using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=CrudMvc;Trusted_Connection=True;Integrated Security=SSPI;TrustServerCertificate=True");
    }
}
