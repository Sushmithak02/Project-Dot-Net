using Book_DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DAL.Repo
{
    public class BookDbContext : DbContext
    {
        public DbSet<BookDetail> BookDetails { get; set; }
        public object UserDetails { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server =(localdb)\mssqllocaldb ; database = BookDB; Trusted_connection=true");
        }
    }
}
