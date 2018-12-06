using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Grain  Grain                 { get; set; }

        public string SpeciesName           { get; set; } //nazwa_gatunek
        public float  AvarageMonthMilkAmout { get; set; } //avg_mleko
    }
}
