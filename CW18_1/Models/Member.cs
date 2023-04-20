using System.ComponentModel.DataAnnotations.Schema;

namespace CW18_1.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
        public Address Address { get; set; }
    }
}
