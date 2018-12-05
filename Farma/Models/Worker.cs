using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farma.Models
{
    public class Worker //pracownik
    {
        [Key]
        public int      Id                  { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId              { get; set; } //id_farmy

        public string   FirstName           { get; set; }
        public string   LastName            { get; set; } //nazwisko z imieniem
        public string   Position            { get; set; } //stanowisko
        public float    Salary              { get; set; } //placa
        public DateTime EmploymentDate      { get; set; } //data_zatrudnienia
        public DateTime EndOfEmploymentDate { get; set; } //koniec_umowy
    }
}
