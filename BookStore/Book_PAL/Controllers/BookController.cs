using Book_DAL.Model;
using Book_DAL.Repo;
using Book_PAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_PAL.Controllers
{
    public class BookController : Controller
    {
        IRepository repo;

        public BookController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<BookDetail> book = repo.ViewAllBooks();
            return View(book);
        }

        [HttpGet]

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddBook(Book book)
        {
            BookDetail detail = new BookDetail()
            {
                AvailabilityStatus = book.AvailabilityStatus,
                Id = book.Id,
                BookName = book.BookName,
                Genre = book.Genre
            };
            bool res = repo.AddBook(detail);

            if (!res)
            {
                View("Error");
            }
            else
            {
                ViewBag.Message = "Added successfully";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult RemoveBook(int Id)
        {

            BookDetail book1 = repo.GetBook(Id);
            return View(book1);
        }

        [HttpPost]

        public IActionResult RemoveBooks(int Id)
        {
            repo.Delete(Id);
            return RedirectToAction("Index");
        }

    }
}
