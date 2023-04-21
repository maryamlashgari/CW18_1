using CW18_1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CW18_1.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryRepository _libraryRepository;

        public LibraryController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }


        public IActionResult DisplayMembers()
        {
            var MembersByState = _libraryRepository.GetAllMemberGroupByState();

            return View(MembersByState);
        }

        public IActionResult DisplayBorrowedBooksByMember()
        {
           var members = _libraryRepository.GetAllBooksBorrowedByMember();
            return View(members);
        }

        public IActionResult GetBooksGroupByStates()
        {
            return View(_libraryRepository.GetBorrowedBooksGroupByState());
        }
    }
}
