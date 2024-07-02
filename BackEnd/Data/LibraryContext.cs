using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<BackEnd.Models.Author> Author { get; set; } = default!;
        public DbSet<BackEnd.Models.Book> Book { get; set; } = default!;
        public DbSet<BackEnd.Models.Borrower> Borrower { get; set; } = default!;
        public DbSet<BackEnd.Models.Borrow> Borrow { get; set; } = default!;
    }
}
