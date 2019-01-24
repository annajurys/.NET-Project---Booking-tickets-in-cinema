// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="Zamowienie.cs" company="">
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
    /// Class Zamowienie.
    /// </summary>
    public class Zamowienie
    {
        /// <summary>
        /// The lista biletow
        /// </summary>
        public List<Bilet> lista_biletow = new List<Bilet>();
        /// <summary>
        /// The seans
        /// </summary>
        public Seans seans;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zamowienie"/> class.
        /// </summary>
        public Zamowienie()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zamowienie"/> class.
        /// </summary>
        /// <param name="s">The s.</param>
        public Zamowienie( Seans s)
        {
            this.seans = s;
            
        }
        /// <summary>
        /// Dodajs the bilet.
        /// </summary>
        /// <param name="b">The b.</param>
        /// <param name="miejsce">The miejsce.</param>
        public void DodajBilet(Bilet b, int miejsce)
        {
            lista_biletow.Add(b);
            b.miejsce = miejsce;
            seans.ZajmijMiejsce(miejsce);
            if (miejsce % 10 == 0)
                b.rzad = miejsce / 10;
            else
                b.rzad = miejsce / 10 + 1;
        }
        /// <summary>
        /// Usuns the bilet.
        /// </summary>
        /// <param name="miejsce">The miejsce.</param>
        public void UsunBilet(int miejsce)
        {
            seans.UsunMiejsce(miejsce);
            lista_biletow.RemoveAll(x=>x.miejsce==miejsce);

        }


        /// <summary>
        /// Gets or sets the lista biletow.
        /// </summary>
        /// <value>The lista biletow.</value>
        internal List<Bilet> Lista_biletow { get => lista_biletow; set => lista_biletow = value; }
        /// <summary>
        /// Gets or sets the seans.
        /// </summary>
        /// <value>The seans.</value>
        internal Seans Seans { get => seans; set => seans = value; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
       
        /// <summary>
        /// SumaZamowienias this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int SumaZamowienia()
        {
            int suma = 0;
            foreach (Bilet b in lista_biletow)
            {
                suma = suma + b.Suma();
            }
            return suma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Zamówienie:");
            sb.AppendLine();
            sb.Append("Wybrany film: \n" + seans.film + "Czas Rozpoczęcia: "+seans.data_i_godzina_rozpoczecia.ToString("dd-MM-yyy HH:mm")+ "\n"+"Czas Zakończenia: " + seans.data_i_godzina_zakonczenia.ToString("dd-MM-yyy HH:mm") + "\nliczba biletów: " + lista_biletow.Count + "\n");
            foreach (Bilet b in lista_biletow)
            {
                
                sb.Append(b+ "\n rząd: " +b.rzad.ToString() + " miejsce: "+ b.miejsce.ToString()+"\n\n");
            }
            sb.Append("Suma zamówienia: " + SumaZamowienia() + "zł\n");
            return sb.ToString();
        }
    }
}
