// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-16-2019
// ***********************************************************************
// <copyright file="Zla_ilosc_miejsc_exception.cs" company="">
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
    /// Class Zla_ilosc_miejsc_exception.
    /// Implements the <see cref="System.Exception" />
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class Zla_ilosc_miejsc_exception:Exception

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zla_ilosc_miejsc_exception"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Zla_ilosc_miejsc_exception(string message) : base(message)
        {

        }
    }
}
