using Book_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DAL.Repo
{
    public interface IRepository
    {
        public bool AddBook(BookDetail book);

        public List<BookDetail> ViewAllBooks();

        public bool Delete(int BookId);

        public BookDetail GetBook(int BookId);
    }
}
