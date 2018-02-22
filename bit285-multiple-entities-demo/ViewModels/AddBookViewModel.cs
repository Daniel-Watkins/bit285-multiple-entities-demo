using IndyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.ViewModels
{
    public class AddBookViewModel
    {
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Publication Year")]
        public string Publication { get; set; }

        public IEnumerable<Author> Authors { get; set; }
    }
}