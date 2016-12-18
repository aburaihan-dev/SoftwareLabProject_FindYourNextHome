using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeRentalBD.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [Column("Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Area { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password Can't be more than 20 character.")]
        [Column("Password")]
        [Display(Name = "Password")]
        protected string Password { get; set; }
    }
}