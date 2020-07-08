using System.Data.Entity;


namespace AlSTO1.Models.Repository
{
    public class EFDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
       
    }
}