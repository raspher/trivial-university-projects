using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lista3zad1
{
    abstract class Samochod
    {
        public int id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string typ { get; set; }
        public int rokProdukcji { get; set; }
        public int pojemnoscSilnika { get; set; }

        virtual public string Pisz()
        {
            return
                $"ID: {marka} \n " +
                $"Marka: {marka} \n" +
                $"Model: {model} \n" +
                $"Typ: {typ} \n" +
                $"Rok produkcji: {rokProdukcji}\n" +
                $"Pojemność: {pojemnoscSilnika}\n";
        }

        public abstract string getPoleDod();
    }
}
