using Book_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DAL.Repo
{
    public class BookServices : IRepository
    {
       BookDbContext db;

        public BookServices()
        {
            db = new BookDbContext();
        }

        public bool AddBook(BookDetail book)
        {
            if(book != null)
            {
                db.BookDetails.Add(book);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<BookDetail> ViewAllBooks()
        {
            return db.BookDetails.ToList();
        }

        public bool Delete(int Id)
        {
            BookDetail book1 = db.BookDetails.Find(Id);
            if (Id != null)
            {
               
                    db.BookDetails.Remove(book1);
                    db.SaveChanges();
               
                return true;
            }
                
            else
            {
                return false;
            }
           
        }

        public BookDetail GetBook(int BookId)
        {
            BookDetail book = db.BookDetails.Find(BookId);
            return book;
        }
    }
}
