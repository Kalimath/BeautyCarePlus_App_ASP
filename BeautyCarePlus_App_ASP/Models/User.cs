using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCarePlus_App_ASP.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Naam")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
    }
}