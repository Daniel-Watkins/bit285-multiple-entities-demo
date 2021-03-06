﻿using System;
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

        // TODO: Create at least three  appropriate properties
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        // TODO: Add Property to represent the entity relationship: "A Member can have many Purchases"
        public virtual ICollection<Purchase> PurchaseHistory { get; set; }
    }
}