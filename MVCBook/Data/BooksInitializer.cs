using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //A
using MVCBook.Models; // A

namespace MVCBook.Data
{
    // Esta clase inicializadora es opcional
    public class BooksInitializer :DropCreateDatabaseAlways<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            var books = new List<Book>
            {
               new Book {
                Name = "DreamBig",
                Author= "Santiago Romano",        
                PagesNumber = 150,
                Publisher = "Dream Editoriales",
                PublicationDate = "02/10/2021",
               Content = "Metodos de Productividad",
               Price = 1000,
               PriceConfirm = 1000
               }
            };
            books.ForEach(b=> context.Books.Add(b));
            context.SaveChanges();
        }
    }
}