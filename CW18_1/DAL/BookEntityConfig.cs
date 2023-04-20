using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18_1.DAL
{
    public class BookEntityConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Book1", ZhanrId = 1 },
                new Book { Id = 2, Title = "Book2", ZhanrId = 2 });
        }
    }
}
