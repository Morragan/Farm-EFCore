using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Silo //zbiornik
    {
        [Key]
        public int Id       { get; set; }
        public int FarmId   { get; set; } //id_farmy
        public int DairyId  { get; set; } //id_mleczarni
        public int Capacity { get; set; } //pojemnosc
        public int Fill     { get; set; } //zapełnienie
    }
}
