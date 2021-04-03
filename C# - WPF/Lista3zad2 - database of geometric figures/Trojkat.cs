using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad2
{
    public class Trojkat : Figura
    {
        Punkt[] punkty = new Punkt[3];
        string typ;

        public Trojkat(
            int id,
            List<Punkt> punkty)
        {
            this.id = id;
            this.rodzaj = "Trójkąt";
            this.punkty = punkty.ToArray();

            double[] dlugosci = new double[3];
            dlugosci[0] = Math.Abs(
                Math.Pow(
                    (
                        Math.Pow((double)punkty[0].x - (double)punkty[2].x, 2) +
                        Math.Pow((double)punkty[0].y - (double)punkty[2].y, 2)
                    )
                , 1.0 / 2));
            dlugosci[1] = Math.Abs(
                Math.Pow(
                    (
                        Math.Pow((double)punkty[1].x - (double)punkty[0].x, 2) +
                        Math.Pow((double)punkty[1].y - (double)punkty[0].y, 2)
                    )
                , 1.0 / 2));
            dlugosci[2] = Math.Abs(
                Math.Pow(
                    (
                        Math.Pow((double)punkty[2].x - (double)punkty[1].x, 2) +
                        Math.Pow((double)punkty[2].y - (double)punkty[1].y, 2)
                    )
                , 1.0 / 2));

            if (dlugosci.Distinct().Count() == 1)
                typ = "równoboczny";
            if (dlugosci.Distinct().Count() == 2)
                typ = "równoramienny";
            if (dlugosci.Distinct().Count() == 3)
                typ = "różnoboczny";
        }

        public override string Wypisz()
        {
            return $"ID: {this.id} \n" +
                $"Rodzaj: {this.rodzaj}\n" +
                $"Typ: {this.typ}\n" +
                $"Wierzchołek 1: {this.punkty[0]}\n" +
                $"Wierzchołek 2: {this.punkty[1]}\n" +
                $"Wierzchołek 3: {this.punkty[2]}\n";
        }
    }
}
