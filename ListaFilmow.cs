using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ListaFilmow
    {
        private List<Film> lista_filmow = new List<Film>();

        internal List<Film> Lista_filmow { get => lista_filmow; set => lista_filmow = value; }
        public ListaFilmow()
        { }
        public void DodajFilm(Film f)
        {
            lista_filmow.Add(f);
        }
        public void UsunFilm(string tytul)
        {
            foreach (Film f in lista_filmow)
            {
                if (f.tytul == tytul)
                {
                    //ListaFilmow.Remove(f);
                    break;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Lista filmow:");
            for (int i = 0; i < lista_filmow.Count; i++)
            {
                //sb.Append(Seans[i]);
            }
            return sb.ToString();
        }
    }
}
