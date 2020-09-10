using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCarePlus_App_ASP.Models
{
    public class MeasuringHeights
    {
        public int Id { get; set; }

        [Display(Name = "Taille")]
        public double Waist { get; set; }

        public double Hip { get; set; }

        [Display(Name = "Dij")]
        public double Thigh { get; set; }

        public double Arm { get; set; }

        [Display(Name = "Kuit")]
        public double Calf { get; set; }

        [Display(Name = "Knie")]
        public double Knee { get; set; }

        [Display(Name = "Opmerking")]
        public string Comment { get; set; }
    }
}