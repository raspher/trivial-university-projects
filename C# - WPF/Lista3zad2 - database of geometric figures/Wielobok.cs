using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad2
{
    public class Wielobok : Figura
    {
        Punkt[] punkty;

        public Wielobok(int id, List<Punkt> punkts)
        {
            this.id = id;
            this.rodzaj = "Wielobok";
            this.punkty = punkts.ToArray();
        }

        public override string Wypisz()
        {
            return $"ID: {this.id}\n" +
                $"Rodzaj: {this.rodzaj}\n" +
                $"Punkty: \n - " +
                $"{string.Join<Punkt>("\n - ", punkty)}";
        }
    }
}
