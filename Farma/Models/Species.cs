using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Species
    {
        public int    Id                    { get; set; }
        public int    GrainId               { get; set; } //id_zboze
        public string SpeciesName           { get; set; } //nazwa_gatunek
        public float  AvarageMonthMilkAmout { get; set; } //avg_mleko
    }
}
