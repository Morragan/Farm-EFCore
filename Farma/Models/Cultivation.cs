using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;

namespace Farma.Models
{
    public class Cultivation // uprawa
    {
        [Key]
        public int      Id                 { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId             { get; set; } //id_farmy
        public Farm     Farm               { get; set; }

        [ForeignKey("Grain")]
        public int      GrainId            { get; set; } //id_zboze
        public Grain    Grain              { get; set; }

        public DateTime LastSowingDate     { get; set; } //data_zasiewu
        public DateTime HarvestOfCropsDate { get; set; } //data_zbioru
    }
}
