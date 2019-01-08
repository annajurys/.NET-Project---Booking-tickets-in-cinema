using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ListaSeansów
    {
        Sala sala;
        List<Seans> lista_seansow = new List<Seans>();

        public ListaSeansów(Sala sala)
        {
            this.sala = sala;
            
        }

        internal Sala Sala { get => sala; set => sala = value; }
        internal List<Seans> Lista_seansow { get => lista_seansow; set => lista_seansow = value; }
    }
}
