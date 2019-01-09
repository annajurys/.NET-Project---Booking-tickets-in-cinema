using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Sala
    {
        private int rzedy;
        private int miejsca;

        public int Rzedy
        {
            get => rzedy; set
            {
                if (value > 0 && value < 10)
                    rzedy = value;
                else
                    throw new Zla_ilosc_miejsc_exception("Zła ilość miejsc!");
            }
        }
        public int Miejsca
        {
            get => miejsca; set
            {
                if (value > 0 && value < 10)
                    miejsca = value;
                else
                    throw new Zla_ilosc_miejsc_exception("Zła ilość miejsc!");
            }
        }
        public Sala(int rzedy, int miejsca)
        {
            this.rzedy = rzedy;
            this.miejsca = miejsca;
        }
        public override string ToString()
        {
            return "Sala: ilosc rzedow: " + rzedy + " Ilosc miejsc w rzedach: " + miejsca;
        }
    }
}
