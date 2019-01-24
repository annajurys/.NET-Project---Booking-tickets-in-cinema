// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="BiletNormalny.cs" company="">
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
    /// Class BiletNormalny.
    /// Implements the <see cref="Projekt.Bilet" />
    /// </summary>
    /// <seealso cref="Projekt.Bilet" />
    public class BiletNormalny:Bilet
    {
        /// <summary>
        /// The cena dodatkowa
        /// </summary>
        public int cena_dodatkowa;
        /// <summary>
        /// Initializes a new instance of the <see cref="BiletNormalny"/> class.
        /// </summary>
        public BiletNormalny():base()
        {
            cena_dodatkowa = 12;
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
            return "Bilet normalny" + ", Cena:" + Suma() + "zł";
        }

    }
}
