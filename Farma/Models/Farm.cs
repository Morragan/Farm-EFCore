using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks; //that shit need to be deleted

namespace Farma.Models
{
    public class Farm
    {
        [Key]
        public int    Id { get; set; }           //id_farmy
        public string Localization { get; set; } //lokalizacja
    }
}
