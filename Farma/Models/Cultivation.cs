using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farma.Models
{
    public class Cultivation // uprawa
    {
        [Key]
        public int      Id                 { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId             { get; set; } //id_farmy

        [ForeignKey("Grain")]
        public int      GrainId            { get; set; } //id_zboze

        public DateTime LastSowingDate     { get; set; } //data_zasiewu
        public DateTime HarvestOfCropsDate { get; set; } //data_zbioru
    }
}
