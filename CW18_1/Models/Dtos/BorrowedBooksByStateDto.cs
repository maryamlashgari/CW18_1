namespace CW18_1.Models.Dtos
{
    public class BorrowedBooksByStateDto
    {
        public string StateName { get; set; }
        public List<string> ListOfBookTitles { get; set; }
    }
}
