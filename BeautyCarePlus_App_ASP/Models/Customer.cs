using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCarePlus_App_ASP.Models
{
    public class Customer
    {
        
        public int Id { get; set; }

        [Display(Name = "Naam")]
        public string Name { get; set; }

        [Display(Name = "Geboortedatum")]
        public DateTime BirthDate { get; set; }

        public double InitialWeight { get; set; }

        public int TurnsLeft { get; set; }

        public string Adres { get; set; }

        public MeasuringHeights MeasuringHeights { get; set; }

    }
}