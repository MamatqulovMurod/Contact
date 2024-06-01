using ContactApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.Broker
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }
    }
}
