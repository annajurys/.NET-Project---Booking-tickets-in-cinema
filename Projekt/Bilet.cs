// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="Bilet.cs" company="">
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
    /// Class Bilet.
    /// </summary>
    public abstract class Bilet
    {
        /// <summary>
        /// The miejsce
        /// </summary>
        public int miejsce;
        /// <summary>
        /// The cena podstawowa
        /// </summary>
        public static int cena_podstawowa=8;
        /// <summary>
        /// The rzad
        /// </summary>
        public int rzad;
        /// <summary>
        /// Initializes a new instance of the <see cref="Bilet"/> class.
        /// </summary>
        public Bilet()
        { }
        /// <summary>
        /// Sumas this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public virtual int Suma()
        {
            return cena_podstawowa;
        }
        /// <summary>
        /// Gets or sets the cena.
        /// </summary>
        /// <value>The cena.</value>
        public int Cena { get => cena_podstawowa; set => cena_podstawowa = value; }

        /// <summary>
        /// Gets or sets the miejsce.
        /// </summary>
        /// <value>The miejsce.</value>
        public int Miejsce { get => miejsce; set => miejsce = value; }
        /// <summary>
        /// Gets or sets the rzad.
        /// </summary>
        /// <value>The rzad.</value>
        public int Rzad { get => rzad; set => rzad = value; }

       

    }
}
