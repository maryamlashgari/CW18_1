using CW18_1.Models;
using CW18_1.Models.Dtos;

namespace CW18_1.Repositories
{
    public interface ILibraryRepository
    {
        List<MemberGroupByStateDto> GetAllMemberGroupByState();
        List<Member> GetAllBooksBorrowedByMember();
        List<BorrowedBooksByStateDto> GetBorrowedBooksGroupByState();
    }
}