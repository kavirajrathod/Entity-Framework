using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class BookContext:DbContext
    {
        public DbSet<Book> Books { set; get; }
        public DbSet<Author> Authors { set; get; }
        public DbSet<Details> Details { get; set; }

    }
}
