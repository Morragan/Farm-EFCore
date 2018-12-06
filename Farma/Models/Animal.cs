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

        [ForeignKey("Species")]
        public int      SpeciesId        { get; set; } //id_gatunek
        public Species Species           { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId           { get; set; } //id_farmy
        public Farm     Farm             { get; set; }

        public DateTime BirthDate        { get; set; } //tutaj problemo
        public bool     Sex              { get; set; } //plec
        public DateTime ImpregnationDate { get; set; } //data_zaplodnienia
    }
}
