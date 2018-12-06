using System;
using System.ComponentModel.DataAnnotations;

namespace Farma.Models
{
    public class Dairy
    {
        [Key]
        public int      Id                { get; set; }
        public int      MilkPricePerLiter { get; set; } //cena_litr
        public DateTime SettlementDate    { get; set; } //data_rozliczenia
        public float    Payment           { get; set; } //wplata
    }
}
