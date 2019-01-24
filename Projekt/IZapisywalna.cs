// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="IZapisywalna.cs" company="">
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
    /// Interface IZapisywalna
    /// </summary>
    interface IZapisywalna
    {
        /// <summary>
        /// Zapiszs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        void ZapiszXML(string nazwa);
        /// <summary>
        /// Odczytajs the XML.
        /// </summary>
        /// <param name="nazwa">The nazwa.</param>
        /// <returns>Object.</returns>
        Object OdczytajXML(string nazwa);
        

    }
}
