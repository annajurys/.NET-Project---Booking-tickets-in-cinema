using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ListaSeansow
    {
        Sala sala;
        List<Seans> lista_seansow = new List<Seans>();

        public ListaSeansow(Sala sala)
        {
            this.sala = sala;
            
        }

        internal Sala Sala { get => sala; set => sala = value; }
        internal List<Seans> Lista_seansow { get => lista_seansow; set => lista_seansow = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Lista seansow:");
            for(int i=0;i<lista_seansow.Count;i++)
            {
                //sb.Append(Seans[i]);
            }
            return sb.ToString();
        }
        public void DodajSeans(Seans f)
        {
            lista_seansow.Add(f);
        }
        /*
        public void UsunSeans(Film film, DateTime data_i_godzina_rozpoczecia)
        {
            foreach (Seans s in lista_seansow)
            {
                if (s.Film == Film)
                {
                    //ListaFilmow.Remove(f);
                    break;
                }
            }
        }*/
    }
   
}
