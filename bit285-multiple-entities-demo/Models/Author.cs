using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        // TODO: Create at least three  appropriate properties
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"
        public ICollection<Book> Books { get; set; }

    }
}