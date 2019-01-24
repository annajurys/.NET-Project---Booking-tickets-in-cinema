// ***********************************************************************
// Assembly         : Projekt
// Author           : user
// Created          : 01-17-2019
//
// Last Modified By : user
// Last Modified On : 01-17-2019
// ***********************************************************************
// <copyright file="Program.cs" company="">
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
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Sala sala = new Sala(100);
            ListaFilmow lista_filmow = new ListaFilmow();
            ListaSeansow lista_seansow = new ListaSeansow();
             
            Film f1 = new Film("Kopciuszek", "Damon Santostefano", 94);
            
            Film f2 = new Film("Życie Pi", "Bruce LEE", 150);
            Film f3 = new Film("Interstellar", "Christopher Nolan", 164);
            Film f4 = new Film("O północy w Paryżu", "Drewniany Allen", 117);
            Film f5= new Film("Świnka Peppa", "Neville Astley", 92);
            Film f6= new Film("Gdzie Jest Nemo", "Andrew Stanton", 93);
            Film f7 = new Film("Prosimy o 5.0", "Mikołaj Fitowski, Klaudia Kowal, Anna Jurys, Małgorzata Dyląg",50);
            Film f8 = new Film("Nietykalni", "Olivier Nakache", 137);
            Film f9 = new Film("Bohemian Rhapsody", "Bryan Singer", 143);
            Film f10 = new Film("Zielona Mila", "Frank Darabonta", 159);
            
            lista_filmow.DodajFilm(f1);
            
            lista_filmow.DodajFilm(f2);
            lista_filmow.DodajFilm(f3);
            lista_filmow.DodajFilm(f4);
            lista_filmow.DodajFilm(f5);
            lista_filmow.DodajFilm(f6);
            lista_filmow.DodajFilm(f7);
            lista_filmow.DodajFilm(f8);
            lista_filmow.DodajFilm(f9);
            lista_filmow.DodajFilm(f10);
            Seans s1 = new Seans(f1, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s2 = new Seans(f1, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s3 = new Seans(f1, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s4 = new Seans(f1, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s5 = new Seans(f1, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s6 = new Seans(f1, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s7 = new Seans(f2, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s8 = new Seans(f2, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s9 = new Seans(f2, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s10 = new Seans(f2, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s11 = new Seans(f2, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s12 = new Seans(f2, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s13 = new Seans(f3, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s14 = new Seans(f3, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s15 = new Seans(f3, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s16 = new Seans(f3, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s17 = new Seans(f3, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s18 = new Seans(f3, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s19 = new Seans(f4, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s20 = new Seans(f4, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s21 = new Seans(f4, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s22 = new Seans(f4, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s23 = new Seans(f4, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s24 = new Seans(f4, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s25 = new Seans(f5, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s26 = new Seans(f5, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s27 = new Seans(f5, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s28 = new Seans(f5, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s29 = new Seans(f5, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s30 = new Seans(f5, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s31 = new Seans(f6, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s32 = new Seans(f6, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s33 = new Seans(f6, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s34 = new Seans(f6, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s35 = new Seans(f6, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s36 = new Seans(f6, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s37 = new Seans(f7, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s38 = new Seans(f7, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s39 = new Seans(f7, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s40 = new Seans(f7, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s41 = new Seans(f7, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s42 = new Seans(f7, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s43 = new Seans(f8, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s44 = new Seans(f8, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s45 = new Seans(f8, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s46 = new Seans(f8, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s47 = new Seans(f8, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s48 = new Seans(f8, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s49 = new Seans(f9, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s50 = new Seans(f9, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s51 = new Seans(f9, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s52 = new Seans(f9, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s53 = new Seans(f9, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s54 = new Seans(f9, new DateTime(2019, 1, 27, 20, 30, 0), sala);
            Seans s55 = new Seans(f10, new DateTime(2019, 1, 29, 17, 30, 0), sala);
            Seans s56 = new Seans(f10, new DateTime(2019, 1, 25, 20, 30, 0), sala);
            Seans s57 = new Seans(f10, new DateTime(2019, 1, 26, 17, 30, 0), sala);
            Seans s58 = new Seans(f10, new DateTime(2019, 1, 26, 20, 30, 0), sala);
            Seans s59 = new Seans(f10, new DateTime(2019, 1, 27, 17, 30, 0), sala);
            Seans s60 = new Seans(f10, new DateTime(2019, 1, 27, 20, 30, 0), sala);




            lista_seansow.DodajSeans(s1);
                lista_seansow.DodajSeans(s2);
                lista_seansow.DodajSeans(s3);
                lista_seansow.DodajSeans(s4);
                lista_seansow.DodajSeans(s5);
               lista_seansow.DodajSeans(s6);
            
                lista_seansow.DodajSeans(s7);
                lista_seansow.DodajSeans(s8);
                lista_seansow.DodajSeans(s9);
                lista_seansow.DodajSeans(s10);
                lista_seansow.DodajSeans(s11);
                lista_seansow.DodajSeans(s12);
                lista_seansow.DodajSeans(s13);
                lista_seansow.DodajSeans(s14);
                lista_seansow.DodajSeans(s15);
                lista_seansow.DodajSeans(s16);
                lista_seansow.DodajSeans(s17);
                lista_seansow.DodajSeans(s18);
                lista_seansow.DodajSeans(s19);
                lista_seansow.DodajSeans(s20);
                lista_seansow.DodajSeans(s21);
                lista_seansow.DodajSeans(s22);
                lista_seansow.DodajSeans(s23);
                lista_seansow.DodajSeans(s24);
                lista_seansow.DodajSeans(s25);
                lista_seansow.DodajSeans(s26);
                lista_seansow.DodajSeans(s27);
                lista_seansow.DodajSeans(s28);
                lista_seansow.DodajSeans(s29);
                lista_seansow.DodajSeans(s30);
                lista_seansow.DodajSeans(s31);
                lista_seansow.DodajSeans(s32);
                lista_seansow.DodajSeans(s33);
                lista_seansow.DodajSeans(s34);
                lista_seansow.DodajSeans(s35);
                lista_seansow.DodajSeans(s36);
                lista_seansow.DodajSeans(s37);
                lista_seansow.DodajSeans(s38);
                lista_seansow.DodajSeans(s39);
                lista_seansow.DodajSeans(s40);
                lista_seansow.DodajSeans(s41);
                lista_seansow.DodajSeans(s42);
                lista_seansow.DodajSeans(s43);
                lista_seansow.DodajSeans(s44);
                lista_seansow.DodajSeans(s45);
                lista_seansow.DodajSeans(s46);
                lista_seansow.DodajSeans(s47);
                lista_seansow.DodajSeans(s48);
                lista_seansow.DodajSeans(s49);
                lista_seansow.DodajSeans(s50);
                lista_seansow.DodajSeans(s51);
                lista_seansow.DodajSeans(s52);
                lista_seansow.DodajSeans(s53);
                lista_seansow.DodajSeans(s54);
                lista_seansow.DodajSeans(s55);
                lista_seansow.DodajSeans(s56);
                lista_seansow.DodajSeans(s57);
                lista_seansow.DodajSeans(s58);
                lista_seansow.DodajSeans(s59);
                lista_seansow.DodajSeans(s60);
            
         
            lista_filmow.Sort();
            lista_seansow.Sortuj();
           lista_filmow.ZapiszXML("filmy.xml");
            
           lista_seansow.ZapiszXML("seanse.xml");

            


            Console.ReadKey();
        }
    }
}
