using System.ComponentModel.DataAnnotations;

namespace CW18_1.Models
{
    public class City
    {
        //public int Id { get; set; }
        public string Name { get; set; }

        [Key]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
