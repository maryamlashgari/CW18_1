using CW18_1.DAL;
using CW18_1.Models;
using CW18_1.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CW18_1.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly AppDBContext _dbContext;
        public LibraryRepository(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public List<MemberGroupByStateDto> GetAllMemberGroupByState()
        {

            List<MemberGroupByStateDto> membersByProvince = _dbContext.Members.Include(m => m.Address)
                            .ThenInclude(a => a.City)
                            .ThenInclude(c => c.State)
                            //
                            .GroupBy(m => m.Address.City.State.Name)
                            .Select(g => new MemberGroupByStateDto
                            {
                                StateName = g.Key,
                                Members = g.ToList()

                            }).ToList();
            return membersByProvince;
        }

        public List<Member> GetAllBooksBorrowedByMember()
        {
            List<Member> booksBorrowedByMemebr =
                 _dbContext.Members.Include(m => m.Books).ToList();
            return booksBorrowedByMemebr;
        }

        public List<BorrowedBooksByStateDto> GetBorrowedBooksGroupByState()
        {
            // List<Book> borrowedBooks = _dbContext.Books.Include(b => b.Members)
            //   .ThenInclude(f => f.Address)
            //   .ThenInclude(i => i.City)
            //   .ThenInclude(c => c.State)
            //   .GroupBy(h=>h.Members.Add)
            //   .ToList();


            //List<State> borrowedBooks = _dbContext.States.Include(b => b.Cities)
            //    .ThenInclude(f => f.Addresses)
            //    .ThenInclude(i => i.Member)
            //    .ThenInclude(c => c.Books).ToList();


            List<BorrowedBooksByStateDto> result = _dbContext.States.Select(u => new BorrowedBooksByStateDto
            {
                StateName = u.Name,
                ListOfBookTitles = u.Cities.SelectMany(f => f.Addresses
                .SelectMany(m => m.Member.Books.Select(b => b.Title))).Distinct().ToList()

            }).ToList();
            //var st = _dbContext.States.Select(u => new BorrowedBooksByStateDto
            //{
            //    StateName = u.Name,
            //    ListOfBookTitles = u.Cities.SelectMany(f => f.Addresses
            //    .SelectMany(m => m.Member.Books.Select(b => b.Title))).Distinct().ToList()
            //
            //}).ToQueryString();
            return result;
        }

    }
}
