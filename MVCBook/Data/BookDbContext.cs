using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBook.Models; //A
using System.Data.Entity;//A
using MVCBook.Data; //A

namespace MVCBook.Data
{
    // agregar el :DbContext!
    public class BookDbContext : DbContext
    {
        
        public BookDbContext() : base("KeyDB") { }
        public DbSet<Book> Books { get; set; }
        
    }
}