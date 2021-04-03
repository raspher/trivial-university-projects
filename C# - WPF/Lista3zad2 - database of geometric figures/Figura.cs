using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad2
{
    public abstract class Figura
    {
        public int id { get; set; }
        public string rodzaj { get; set; }

        public abstract string Wypisz();
    }
}
