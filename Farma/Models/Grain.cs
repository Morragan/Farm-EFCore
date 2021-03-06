﻿using System.ComponentModel.DataAnnotations;

namespace Farma.Models
{
    public class Grain
    {
        [Key]
        public int    Id                 { get; set; }
        public string Name               { get; set; } //nazwa
        public float  PricePerKg         { get; set; } //cena_kg
        public int    GrainNeededPerYear { get; set; } //zap-rok
        public int    GrainHaving        { get; set; } //posiadane_kg
    }
}
