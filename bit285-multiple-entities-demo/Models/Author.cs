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

        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"

    }
}