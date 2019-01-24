// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="ListaFilmow.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    /// <summary>
    /// Class ListaFilmow.
    /// Implements the <see cref="System.ICloneable" />
    /// Implements the <see cref="Projekt.IZapisywalna" />
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    /// <seealso cref="Projekt.IZapisywalna" />
    public class ListaFilmow : ICloneable,IZapisywalna
    {
        /// <summary>
        /// The lista filmow
        /// </summary>
        public List<Film> lista_filmow = new List<Film>();
        /// <summary>
        /// Gets or sets the lista filmow.
        /// </summary>
        /// <value>The lista filmow.</value>
        public List<Film> Lista_filmow { get => lista_filmow; set => lista_filmow = value; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaFilmow"/> class.
        /// </summary>
        public ListaFilmow()
        { }
        /// <summary>
        /// Dodajs the film.
        /// </summary>
        /// <param name="f">The f.</param>
        public void DodajFilm(Film f)
        {
            lista_filmow.Add(f);
        }
        /// <summary>
        /// Usuns the film.
        /// </summary>
        /// <param name="tytul">The tytul.</param>
        public void UsunFilm(string tytul)
        {
            foreach (Film f in lista_filmow)
            {
                if (f.tytul == tytul)
                {
                    lista_filmow.Remove(f);
                    break;
                }
            }
        }
        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void Sort()
        {
            lista_filmow.Sort();
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Film f in lista_filmow)
            {
                sb.Append(f);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            ListaFilmow klon = new ListaFilmow();
            foreach (Film f in lista_filmow)
            {
                klon.DodajFilm(f.Clone() as Film);
            }
            return klon;
        }
        /// <summary>
        /// Zapiszs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        public void ZapiszXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, this.lista_filmow);
            writer.Close();
        }
        /// <summary>
        /// Odczytajs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        /// <returns>Object.</returns>
        public Object OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));

            using (StreamReader reader = new StreamReader(nazwa))
            {
                ListaFilmow wynik = new ListaFilmow();
                wynik.lista_filmow = serializer.Deserialize(reader) as List<Film>;
                return wynik;
            }
        }
    }
}