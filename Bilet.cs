using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public enum Rodzaj_biletu { ulgowy,normalny}
    class Bilet
    {
        private int cena;
        private Rodzaj_biletu rodzaj_biletu;

        public Bilet(Rodzaj_biletu rodzaj_biletu)
        {
            this.rodzaj_biletu = rodzaj_biletu;
            if (rodzaj_biletu == Rodzaj_biletu.normalny)
                cena = 20;
            else cena = 10;
        }
        public int Cena { get => cena; set => cena = value; }
        public Rodzaj_biletu Rodzaj_biletu { get => rodzaj_biletu; set => rodzaj_biletu = value; }

        public override string ToString()
        {
            return "Bilet: Rodzaj biletu: " + rodzaj_biletu + " Cena: " + cena;
        }

    }
}
