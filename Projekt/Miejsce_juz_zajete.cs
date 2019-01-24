using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
   public class Miejsce_juz_zajete:Exception
    {
        public Miejsce_juz_zajete(string message):base(message)
        { }
    }
}
