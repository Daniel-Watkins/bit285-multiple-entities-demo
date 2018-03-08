﻿using System;
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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        // Property to represent the entity relationship: "An Author can write many Books"
        public ICollection<Book> Books { get; set; }
    }
}