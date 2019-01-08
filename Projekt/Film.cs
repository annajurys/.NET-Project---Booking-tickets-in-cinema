using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Film
    {
        private string tytul;
        private string rezyser;
        private int czas_trwania;//w minutach

        public Film(string tytul, string rezyser, int czas_trwania)
        {
            this.tytul = tytul;
            this.rezyser = rezyser;
            this.czas_trwania = czas_trwania;
        }

        public string Tytul { get => tytul; set => tytul = value; }
        public string Rezyser { get => rezyser; set => rezyser = value; }
        public int Czas_trwania {
            get => czas_trwania; set
            {
                if (value > 0)
                    czas_trwania = value;
                else
                    throw new Ujemny_czas_trwania_filmu_exception("Zła dlugość filmu!");
            }
        }
    }
}
