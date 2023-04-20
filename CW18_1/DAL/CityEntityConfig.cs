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

            builder.HasOne(e => e.Address)
           .WithOne(e => e.City)
           .HasForeignKey<City>(e => e.AddressId);

            //builder.HasData(new City
            //{
            //    //Id = 1,
            //    AddressId = 1,
            //    Name = "tehran",
            //    StateId = 1
            //});

            builder.HasData(
                new City {Name = "City1", AddressId = 1, StateId = 1 },
                new City {Name = "City2", AddressId = 2, StateId = 2 });
        }
    }
}
