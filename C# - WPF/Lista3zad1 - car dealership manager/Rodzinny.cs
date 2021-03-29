using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad1
{
    class Rodzinny : Samochod
    {
        public string miejsc { get; set; }

        public Rodzinny(
            int id,
            string marka,
            string model,
            string typ,
            int rokProdukcji,
            int pojemnoscSilnika,
            string miejsc
            )
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.typ = typ;
            this.rokProdukcji = rokProdukcji;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.miejsc = miejsc;
        }

        override public string Pisz()
        {
            return 
                $"ID: {marka} \n " +
                $"Marka: {marka} \n" +
                $"Model: {model} \n" +
                $"Typ: {typ} \n" +
                $"Rok produkcji: {rokProdukcji}\n" +
                $"Pojemność: {pojemnoscSilnika}\n" +
                $"Miejsc siedzących: {miejsc}";
        }

        public override string getPoleDod()
        {
            return this.miejsc;
        }
    }
}
