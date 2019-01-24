// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-16-2019
// ***********************************************************************
// <copyright file="Film.cs" company="">
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
    /// Class Film.
    /// Implements the <see cref="System.IComparable{Projekt.Film}" />
    /// Implements the <see cref="System.ICloneable" />
    /// </summary>
    /// <seealso cref="System.IComparable{Projekt.Film}" />
    /// <seealso cref="System.ICloneable" />
    public class Film:IComparable<Film>,ICloneable
    {
        /// <summary>
        /// The tytul
        /// </summary>
        public string tytul;
        /// <summary>
        /// The rezyser
        /// </summary>
        public string rezyser;
        /// <summary>
        /// The czas trwania
        /// </summary>
        public int czas_trwania;//w minutach
        /// <summary>
        /// Initializes a new instance of the <see cref="Film"/> class.
        /// </summary>
        public Film()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Film"/> class.
        /// </summary>
        /// <param name="tytul">The tytul.</param>
        /// <param name="rezyser">The rezyser.</param>
        /// <param name="czas_trwania">The czas trwania.</param>
        public Film(string tytul, string rezyser, int czas_trwania)
        {
            this.tytul = tytul;
            this.rezyser = rezyser;
            Czas_trwania = czas_trwania;
        }

        /// <summary>
        /// Gets or sets the tytul.
        /// </summary>
        /// <value>The tytul.</value>
        public string Tytul { get => tytul; set => tytul = value; }
        /// <summary>
        /// Gets or sets the rezyser.
        /// </summary>
        /// <value>The rezyser.</value>
        public string Rezyser { get => rezyser; set => rezyser = value; }
        /// <summary>
        /// Gets or sets the czas trwania.
        /// </summary>
        /// <value>The czas trwania.</value>
        /// <exception cref="Ujemny_czas_trwania_filmu_exception">Zła dlugość filmu!</exception>
        public int Czas_trwania {
            get => czas_trwania; set
            {
                if (value > 0)
                    czas_trwania = value;
                else
                    throw new Ujemny_czas_trwania_filmu_exception("Zła dlugość filmu!");
            }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="other" /> in the sort order.  Zero This instance occurs in the same position in the sort order as <paramref name="other" />. Greater than zero This instance follows <paramref name="other" /> in the sort order.</returns>
        public int CompareTo(Film other)
        {
            return this.tytul.CompareTo(other.tytul);//Jak sie da minus przed this to sortuje malejaco
        }
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Tytul filmu: " + tytul + "\n" + "Rezyser: " + rezyser + "\n" + "Czas trwania: " + czas_trwania + "min.\n";
        }
    }
}
