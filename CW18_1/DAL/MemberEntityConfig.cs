using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics;
using System.Reflection.Emit;

namespace CW18_1.DAL
{
    public class MemberEntityConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasMany<Book>(s => s.Books)
                .WithMany(g => g.Members);

            //builder.HasData(new Member
            //{
            //    Id = 1,
            //    FirstName = "رضا",
            //    LastName = "rezayi",

            //});

            builder.HasData(
                new Member { Id = 1, FirstName = "FirstName1", LastName = "LastName1" },
                new Member { Id = 2, FirstName = "FirstName2", LastName = "LastName2" });
        }
    }
}
