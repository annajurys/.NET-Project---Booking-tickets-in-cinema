// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="ListaSeansow.cs" company="">
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
    /// Class ListaSeansow.
    /// Implements the <see cref="System.ICloneable" />
    /// Implements the <see cref="Projekt.IZapisywalna" />
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    /// <seealso cref="Projekt.IZapisywalna" />
    public class ListaSeansow:ICloneable,IZapisywalna
    {
        /// <summary>
        /// The lista seansow
        /// </summary>
        public List<Seans> lista_seansow = new List<Seans>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListaSeansow"/> class.
        /// </summary>
        public ListaSeansow()
        { }


        /// <summary>
        /// Gets or sets the lista seansow.
        /// </summary>
        /// <value>The lista seansow.</value>
        internal List<Seans> Lista_seansow { get => lista_seansow; set => lista_seansow = value; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Lista filmow:");
            foreach (Seans s in lista_seansow)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
        /// <summary>
        /// Dodajs the seans.
        /// </summary>
        /// <param name="f">The f.</param>
        public void DodajSeans(Seans f)
        {
            lista_seansow.Add(f);
        }
        /// <summary>
        /// Sortujs this instance.
        /// </summary>
        public void Sortuj()
        {
            lista_seansow.Sort();
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            ListaSeansow klon = new ListaSeansow();
            foreach (Seans s in this.lista_seansow)
                klon.DodajSeans(s.Clone() as Seans);
            return klon;
        }

        /// <summary>
        /// Zapiszs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        public void ZapiszXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListaSeansow));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer,this);
            writer.Close();
        }
        /// <summary>
        /// Odczytajs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        /// <returns>Object.</returns>
        public Object OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListaSeansow));

            using (StreamReader reader = new StreamReader(nazwa))
            {
                ListaSeansow wynik = serializer.Deserialize(reader) as ListaSeansow;
                return wynik;
            }
        }
        
public void UsunSeans(Film film, DateTime data_i_godzina_rozpoczecia)
{
   foreach (Seans s in lista_seansow)
   {
       if (s.Film == film&&s.data_i_godzina_rozpoczecia==data_i_godzina_rozpoczecia)
       {
           lista_seansow.Remove(s);
           break;
       }
   }
}
    }
   
}
