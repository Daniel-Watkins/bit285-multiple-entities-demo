using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        // Property to represent the entity relationship: "A Member can have many Purchases"
        public ICollection<Purchase> Purchases { get; set; }
    }
}