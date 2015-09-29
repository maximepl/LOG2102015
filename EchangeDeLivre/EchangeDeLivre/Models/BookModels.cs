using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EchangeDeLivre.Models
{
    public class BookModels
    {
    }

    public class AddBookViewModel
    {
        //[Required]
        
    }

    public class Book
    {
        [Display(Name = "Code du livre")]
        public string BookCode { get; set; }

        public int ID { get; set; }
        public string ISBN { get; set; }
        public string EAN { get; set; }
        public string UPC { get; set; }
        public string BookCondition { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public int ID { get; set; }
        public string ISBN { get; set; }
        public string EAN { get; set; }
        public string UPC { get; set; }
        public string BookCondition { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PageNumber { get; set; }
        public string Price { get; set; }

    }
}