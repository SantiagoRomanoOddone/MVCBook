using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;//a
using System.ComponentModel.DataAnnotations;

namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "The Name field is required")]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Author { get; set; }
        [Range(100, 10000)]
        public int PagesNumber { get; set; }
        [Column(TypeName = "varchar")]
        public string Publisher { get; set; }
        [Column(TypeName = "varchar")]
  
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage = " Ingrese un formato de fecha válido, Por ejemplo: 2017-06-16 ")]

        public string PublicationDate { get; set; }
        [Column(TypeName = "varchar")]
        public string Content { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        [System.ComponentModel.DataAnnotations.Compare("Price")] //Los precios ingresados dos veces deben ser los mismos
        public decimal PriceConfirm { get; set; }
    }
}