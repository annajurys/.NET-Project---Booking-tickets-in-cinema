using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Seans
    {
        private Film film;
        private DateTime data_i_godzina_rozpoczecia;
        private DateTime data_i_godzina_zakonczenia;

        public Seans(Film film, DateTime data_i_godzina_rozpoczecia)
        {
            this.film = film;
            this.data_i_godzina_rozpoczecia = data_i_godzina_rozpoczecia;
            Data_i_godzina_zakonczenia = Data_i_godzina_rozpoczecia.AddMinutes(film.Czas_trwania);
        }

        internal Film Film { get => film; set => film = value; }
        public DateTime Data_i_godzina_rozpoczecia { get => data_i_godzina_rozpoczecia; set => data_i_godzina_rozpoczecia = value; }
        public DateTime Data_i_godzina_zakonczenia { get => data_i_godzina_zakonczenia; set => data_i_godzina_zakonczenia = value; }

        public override string ToString()
        {
            return "Seans filmu: " + Film + "Data i godzina rozpoczecia filmu: " + data_i_godzina_rozpoczecia + "Data i godzina zakonczenia filmu: " + Data_i_godzina_zakonczenia;
        }
    }
}
