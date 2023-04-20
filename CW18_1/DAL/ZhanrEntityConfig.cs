using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18_1.DAL
{
    public class ZhanrEntityConfig : IEntityTypeConfiguration<Zhanr>
    {
        public void Configure(EntityTypeBuilder<Zhanr> builder)
        {
            builder.HasMany<Book>(b => b.Books)
                .WithOne(z => z.zhanr)
                .HasForeignKey(c => c.ZhanrId);
            //builder.HasData(new Zhanr
            //{
            //    Id = 1,
            //    Title = "ZhanrTitle"
            //});



            builder.HasData(
                new Zhanr { Id = 1, Title = "Zhanr1" },
                new Zhanr { Id = 2, Title = "Zhanr2" });
        }
    }
}
