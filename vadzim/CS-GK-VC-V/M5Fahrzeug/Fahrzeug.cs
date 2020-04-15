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
        public int MaxGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public Zustand zustand { get; set; }

        public Fahrzeug(string name, int preis, int maximalGeschwindigkeit)
        {
            Name = name;
            Preis = preis;
            this.MaximalGeschwindigkeit = maximalGeschwindigkeit;
            this.Zustand = TransportZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        //Methoden
        public int Beschleunigen(int km)
        {
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && Zustand == TransportZustand.Fahrend)
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
            if (Zustand == TransportZustand.Fahrend)
            {
                this.AktuelleGeschwindigkeit += 5;
            }
        }

        public void StoppeMotor()
        {
            this.Zustand = TransportZustand.Fahrend;
        }

        public void Parke()
        {
            this.Zustand = TransportZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $"{Name} ({Preis} Euro): Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h | Zustand: {Zustand}| Mom. Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }

    }
}
