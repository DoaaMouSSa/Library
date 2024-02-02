using db.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.DatabaseContext
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Book> tblBook { get; set; }
    }
}
