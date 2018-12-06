using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farma.Models
{
    public class MilkQuantity //ilosc_mleka
    {
        [Key]
        public int      Id          { get; set; }
        
        [ForeignKey("Animal")]
        public int      AnimalId    { get; set; }
        public Animal Animal        { get; set; }

        public DateTime MilkingDate { get; set; } //data_dojenia
        public int      MilkAmount  { get; set; } //ilosc_mleka_l
    }     
}
