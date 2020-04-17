using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class Fahrzeug
    {
        public enum Zustand { Fahrend, Stehend }
        public string Name { get; set; }
        public int MaximalGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public Zustand FZustand { get; set; }

        public Fahrzeug(string name, int preis, int maximalGeschwindigkeit)
        {
            Name = name;
            Preis = preis;
            this.MaximalGeschwindigkeit = maximalGeschwindigkeit;
            this.FZustand = Zustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        //Methoden
        public int Beschleunigen(int km)
        {
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && FZustand == Zustand.Fahrend)
            {
                AktuelleGeschwindigkeit += km;
            }
            else
            {
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;
            }
            return AktuelleGeschwindigkeit;
        }
        public void StarteMotor()
        {
            if (FZustand == Zustand.Fahrend)
            {
                this.AktuelleGeschwindigkeit += 5;
            }
        }

        public void StoppeMotor()
        {
            this.FZustand = Zustand.Fahrend;
        }

        public void Parke()
        {
            this.FZustand = Zustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $"{Name} ({Preis} Euro): Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h | Zustand: {FZustand}| Mom. Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }

    }
}
