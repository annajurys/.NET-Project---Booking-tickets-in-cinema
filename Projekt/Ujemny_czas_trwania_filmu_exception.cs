using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Ujemny_czas_trwania_filmu_exception:Exception
    {
        public Ujemny_czas_trwania_filmu_exception(string message) : base(message)
        {

        }
    }
}
