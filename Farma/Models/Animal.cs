using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farma.Models
{
    public class Animal // Zwierze
    {
        [Key]
        public int      Id               { get; set; }

        [ForeignKey("Species")]
        public int      SpeciesId        { get; set; } //id_gatunek

        [ForeignKey("Farm")]
        public int      FarmId           { get; set; } //id_farmy

        public DateTime BirthDate        { get; set; } //tutaj problemo
        public bool     Sex              { get; set; } //plec
        public DateTime ImpregnationDate { get; set; } //data_zaplodnienia
    }
}
