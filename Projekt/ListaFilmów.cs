using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ListaFilmów
    {
        private List<Film> lista_filmow = new List<Film>();

        internal List<Film> Lista_filmow { get => lista_filmow; set => lista_filmow = value; }
        public ListaFilmów()
        { }
        public void DodajFilm(Film f)
        {
            lista_filmow.Add(f);
        }
    }
}
