using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CW18_1.DAL
{
    public class CityEntityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder.HasMany(c => c.Addresses)
           .WithOne(e => e.City)
           .HasForeignKey(c => c.CityId);

            //builder.HasData(new City
            //{
            //    //Id = 1,
            //    AddressId = 1,
            //    Name = "tehran",
            //    StateId = 1
            //});

            builder.HasData(
                new City { Id = 1, Name = "City1", StateId = 1 },
                new City { Id = 2, Name = "City2", StateId = 2 });
        }
    }
}
