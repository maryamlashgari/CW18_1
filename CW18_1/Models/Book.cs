namespace CW18_1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Member> Members { get; set; }
        public int ZhanrId { get; set; }
        public Zhanr zhanr { get; set; }
    }
}
