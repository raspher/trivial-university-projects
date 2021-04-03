using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad2
{
    public class Kolo : Figura
    {
        public int promien { get; set; }
        public Punkt punkt { get; set; }

        public Kolo(int id, Punkt punkt, int promien)
        {
            this.id = id;
            this.rodzaj = "Koło";
            this.punkt = punkt;
            this.promien = promien;
        }

        public override string Wypisz()
        {
            return $"ID: {this.id}\n" +
                $"Rodzaj: {this.rodzaj}\n" +
                $"Środek: {this.punkt.ToString()}\n" +
                $"Promień: {this.promien}";
        }
    }
}
