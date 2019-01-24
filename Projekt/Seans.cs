// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-16-2019
// ***********************************************************************
// <copyright file="Seans.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    /// <summary>
    /// Class Seans.
    /// Implements the <see cref="System.IComparable{Projekt.Seans}" />
    /// Implements the <see cref="System.ICloneable" />
    /// </summary>
    /// <seealso cref="System.IComparable{Projekt.Seans}" />
    /// <seealso cref="System.ICloneable" />
    public class Seans:IComparable<Seans>, ICloneable
    {
        /// <summary>
        /// The film
        /// </summary>
        public Film film;
        /// <summary>
        /// The data i godzina rozpoczecia
        /// </summary>
        public DateTime data_i_godzina_rozpoczecia;
        /// <summary>
        /// The data i godzina zakonczenia
        /// </summary>
        public DateTime data_i_godzina_zakonczenia;
        /// <summary>
        /// The sala
        /// </summary>
        public Sala sala;
        /// <summary>
        /// The plan
        /// </summary>
        public int[] plan;




        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        /// <value>The plan.</value>
        public int[] Plan { get => plan; set => plan = value; }
        /// <summary>
        /// Gets or sets the sala.
        /// </summary>
        /// <value>The sala.</value>
        internal Sala Sala { get => sala; set => sala = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seans"/> class.
        /// </summary>
        public Seans()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Seans"/> class.
        /// </summary>
        /// <param name="film">The film.</param>
        /// <param name="data_i_godzina_rozpoczecia">The data i godzina rozpoczecia.</param>
        /// <param name="s">The s.</param>
        public Seans(Film film, DateTime data_i_godzina_rozpoczecia,Sala s)
        {
            this.film = film;
            this.data_i_godzina_rozpoczecia = data_i_godzina_rozpoczecia;
            Data_i_godzina_zakonczenia = Data_i_godzina_rozpoczecia.AddMinutes(film.Czas_trwania);
            this.sala = s;
            plan = new int[sala.Miejsca];

        }


        /// <summary>
        /// Gets or sets the film.
        /// </summary>
        /// <value>The film.</value>
        internal Film Film { get => film; set => film = value; }
        /// <summary>
        /// Gets or sets the data i godzina rozpoczecia.
        /// </summary>
        /// <value>The data i godzina rozpoczecia.</value>
        public DateTime Data_i_godzina_rozpoczecia { get => data_i_godzina_rozpoczecia; set => data_i_godzina_rozpoczecia = value; }
        /// <summary>
        /// Gets or sets the data i godzina zakonczenia.
        /// </summary>
        /// <value>The data i godzina zakonczenia.</value>
        public DateTime Data_i_godzina_zakonczenia { get => data_i_godzina_zakonczenia; set => data_i_godzina_zakonczenia = value; }


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return   data_i_godzina_rozpoczecia.ToString("HH:mm");
        }
        /// <summary>
        /// Zajmijs the miejsce.
        /// </summary>
        /// <param name="miejsce">The miejsce.</param>
        /// <exception cref="Projekt.Miejsce_juz_zajete_exception">Miejsce jest już zajęte</exception>
        public void ZajmijMiejsce(int miejsce)
        {
            if (plan[miejsce - 1] == 1)
                throw new Miejsce_juz_zajete_exception("Miejsce jest już zajęte");
            else
                plan[miejsce - 1] = 1;
        }
        /// <summary>
        /// Usuns the miejsce.
        /// </summary>
        /// <param name="miejsce">The miejsce.</param>
        public void UsunMiejsce(int miejsce)
        {
            plan[miejsce - 1] = 0;
        }
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            Seans klon = new Seans(film.Clone() as Film, this.data_i_godzina_rozpoczecia,this.Sala);
            return klon;
        }
        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(Seans other)
        {
            return this.data_i_godzina_rozpoczecia.CompareTo(other.data_i_godzina_rozpoczecia);
        }
    }
}
