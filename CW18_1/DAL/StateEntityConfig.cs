using CW18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18_1.DAL
{
    public class StateEntityConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasMany<City>(c => c.Cities)
                .WithOne(s => s.State)
                .HasForeignKey(c => c.StateId);
            //builder.HasData(new State
            //{
            //    Id = 1,
            //    Name = "state"
            //});

            builder.HasData(
                new State { Id = 1, Name = "State1" },
                new State { Id = 2, Name = "State2" });
        }
    }
}
