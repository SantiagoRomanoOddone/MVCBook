using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBook.Models; //a
using MVCBook.Data; //A
using System.Data.Entity; //a

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {
        // Crear Instancia del dbcontext 

        private BookDbContext context = new BookDbContext();
        // GET: Book
        public ActionResult Index()
        {
            //Traer todos los Books usando EF
            var books = context.Books.ToList();
            // el controller retorna una vista "Index" con una lista de books
            return View("Index", books);
        }
        [HttpGet] // el Get es implicito, así y todo lo podemos indicar
        public ActionResult Create()
        {
            // creamos la instancia sin valores en las properties
            Book book = new Book();
            //retornamos la vista "Create" que tiene el objeto book

            return View("Create", book);
        }
        // Segundo create es por POST para insertar un nuevo book en la base 
        // cuando el usuario en la vista create hace click en enviar 
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("create", book);
        }

    }
}