using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo_EF
{
    public class FahrzeugEF
    {
        public enum Zustand { Fahrend, Stehend }
        [Key]
        public string Name { get; set; }  
        [ReadOnly(true)]
        public int MaximalGeschwindigkeit { get; set; }
        [Required]
        public double Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public Zustand FZustand { get; set; }
    }
}
