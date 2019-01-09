using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //nasze podstawowe 3 obiekty z ktorych bedziemy korzystac
            Sala sala = new Sala(10,10);
            ListaFilmow lista_filmow = new ListaFilmow();
            ListaSeansow lista_seansow = new ListaSeansow(sala);

            Console.WriteLine("\nNasza sala:\n");
            Console.WriteLine(sala);
            Console.WriteLine("\nNasza lista filmow:\n");
            Console.WriteLine(lista_filmow);
            Console.WriteLine("\nNasza lista seansow:\n");
            Console.WriteLine(lista_seansow);


            //Film f1 = new Film("Kopciuszek", "Disney", 120);
        }
    }
}
