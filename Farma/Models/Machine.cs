using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Farma.Models
{
    public class Machine
    {
        [Key]
        public int      Id                     { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId                 { get; set; }
        public Farm     Farm                   { get; set; }

        public int      Kind                   { get; set; } //rodzaj
        public DateTime ServiceDate            { get; set; } //data_serwisu
        public float    AmountOfFuelLastInTank { get; set; } //ilosc_paliwa
        public float    TankCapacity           { get; set; } //poj_zbiornika
    }
}
