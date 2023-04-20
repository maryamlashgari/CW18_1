using System.ComponentModel.DataAnnotations;

namespace CW18_1.Models
{
    public class Address
    {
        //public int Id { get; set; }
        public string Addresss { get; set; }

        [Key]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public City City { get; set; }
    }
}
