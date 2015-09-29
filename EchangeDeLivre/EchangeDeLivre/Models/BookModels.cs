using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EchangeDeLivre.Models
{
    public class BookModels
    {
    }

    public class AddBookViewModel
    {
        [Required]
        [Display(Name = "Code du livre")]
        public string BookCode { get; set; }
    }
}