// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="Sala.cs" company="">
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
    /// Class Sala.
    /// Implements the <see cref="System.ICloneable" />
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class Sala:ICloneable
    {

        /// <summary>
        /// The miejsca
        /// </summary>
        public int miejsca;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sala"/> class.
        /// </summary>
        public Sala()
        {
            miejsca = 100;
        }

        /// <summary>
        /// Gets or sets the miejsca.
        /// </summary>
        /// <value>The miejsca.</value>
        /// <exception cref="Zla_ilosc_miejsc_exception">Zła ilość miejsc!</exception>
        public int Miejsca
        {
            get => miejsca; set
            {
                if (value > 0 && value-1< 100)
                    miejsca = value;
                else
                    throw new Zla_ilosc_miejsc_exception("Zła ilość miejsc!");
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sala"/> class.
        /// </summary>
        /// <param name="miejsca">The miejsca.</param>
        public Sala(int miejsca)
        {
       
            Miejsca = miejsca;
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Sala: Ilosc miejsc: " + miejsca+"\n";
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
