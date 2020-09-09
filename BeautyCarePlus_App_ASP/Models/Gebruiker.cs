using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCarePlus_App_ASP.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Paswoord { get; set; }
    }
}