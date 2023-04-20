using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CW18_1.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberEntityConfig());
            modelBuilder.ApplyConfiguration(new StateEntityConfig());
            modelBuilder.ApplyConfiguration(new AddressEntityConfig());
            modelBuilder.ApplyConfiguration(new CityEntityConfig());
            modelBuilder.ApplyConfiguration(new ZhanrEntityConfig());
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Zhanr> Zhanrs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
