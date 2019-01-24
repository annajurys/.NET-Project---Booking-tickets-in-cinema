// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="BiletUlgowy.cs" company="">
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
    /// Class BiletUlgowy.
    /// Implements the <see cref="Projekt.Bilet" />
    /// </summary>
    /// <seealso cref="Projekt.Bilet" />
    public class BiletUlgowy:Bilet
    {
        /// <summary>
        /// The cena dodatkowa
        /// </summary>
        public int cena_dodatkowa;
        /// <summary>
        /// Initializes a new instance of the <see cref="BiletUlgowy"/> class.
        /// </summary>
        public BiletUlgowy():base()
        {
            cena_dodatkowa = 2;
        }
        /// <summary>
        /// Sumas this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public override int Suma()
        {
            return cena_podstawowa + cena_dodatkowa;
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Bilet ulgowy" + ", Cena:" + Suma() + "zł";
        }
    }
}
