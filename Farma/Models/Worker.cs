﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farma.Models
{
    public class Worker //pracownik
    {
        [Key]
        public int      Id                  { get; set; }

        [ForeignKey("Farm")]
        public int      FarmId              { get; set; } //id_farmy
        public Farm     Farm                { get; set; }

        public string   FirstName           { get; set; }
        public string   LastName            { get; set; } //nazwisko z imieniem
        public string   Position            { get; set; } //stanowisko
        public float    Salary              { get; set; } //placa
        public DateTime EmploymentDate      { get; set; } //data_zatrudnienia
        public DateTime EndOfEmploymentDate { get; set; } //koniec_umowy
    }
}
