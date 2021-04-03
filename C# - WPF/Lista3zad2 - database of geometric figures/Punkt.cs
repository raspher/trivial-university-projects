using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad2
{
    public class Punkt : Figura
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punkt (int id, int x, int y)
        {
            this.id = id;
            this.rodzaj = "Punkt";
            this.x = x;
            this.y = y;
        }

        public Punkt (int id)
        {
            this.id = id;
            this.rodzaj = "Punkt";
        }

        public override string Wypisz()
        {
            return $"ID: {this.id}\n" +
                $"Rodzaj: {this.rodzaj}\n" +
                $"Współrzędna X: {this.x}\n" +
                $"Współrzędna Y: {this.y}";
        }

        public override string ToString()
        {
            return $"{this.x}, {this.y}";
        }
    }
}
