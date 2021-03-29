using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3zad1
{
    class Sportowy : Samochod
    {
        public int moc { get; set; }

        public Sportowy(
            int id,
            string marka,
            string model,
            string typ,
            int rokProdukcji,
            int pojemnoscSilnika,
            int moc
            )
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.typ = typ;
            this.rokProdukcji = rokProdukcji;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.moc = moc;
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
                $"Moc (KM): {moc}";
        }

        public override string getPoleDod()
        {
            return this.moc.ToString();
        }
    }
}
