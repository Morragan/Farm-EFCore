using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Animal // Zwierze
    {
        [Key]
        public int      Id               { get; set; }
        public int      SpeciesId        { get; set; } //id_gatunek
        public int      FarmId           { get; set; } //id_farmy
        public DateTime BirthDate        { get; set; } //tutaj problemo
        public bool     Sex              { get; set; } //plec
        public DateTime ImpregnationDate { get; set; } //data_zaplodnienia
    }
}
