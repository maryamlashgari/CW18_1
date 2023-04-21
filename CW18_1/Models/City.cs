using System.ComponentModel.DataAnnotations;

namespace CW18_1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Address> Addresses { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
