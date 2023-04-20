using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18_1.DAL
{
    public class AddressEntityConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(e => e.Member)
            .WithOne(e => e.Address)
            .HasForeignKey<Address>(e => e.MemberId);

            //builder.HasData(new Address
            //{
            //    //Id = 1,
            //    Addresss = "dfdsf",
            //    MemberId = 1,


            //});

            builder.HasData(
                new Address { Addresss = "Address1", MemberId = 1 },
                new Address { Addresss = "Address2", MemberId = 2 }
                );



        }
    }
}
