using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Machine
    {
        public int      Id                     { get; set; }
        public int      FarmId                 { get; set; }
        public int      Kind                   { get; set; } //rodzaj
        public DateTime ServiceDate            { get; set; } //data_serwisu
        public float    AmountOfFuelLastInTank { get; set; } //ilosc_paliwa
        public float    TankCapacity           { get; set; } //poj_zbiornika
    }
}
