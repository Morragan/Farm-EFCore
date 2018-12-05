using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Species
    {
        [Key]
        public int    Id                    { get; set; }

        [ForeignKey("Grain")]
        public int    GrainId               { get; set; } //id_zboze

        public string SpeciesName           { get; set; } //nazwa_gatunek
        public float  AvarageMonthMilkAmout { get; set; } //avg_mleko
    }
}
