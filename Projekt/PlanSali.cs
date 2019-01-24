using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class PlanSali
    {
        public Sala sala;
        public int[] plan;
        public Seans seans;

        public PlanSali()
        { }
        public PlanSali(Sala sala, Seans seans)
        {
            this.Seans = seans;
            this.Sala = sala;
            plan = new int[sala.Miejsca];
            
        }

        public int[] Plan { get => plan; set => plan = value; }
        internal Sala Sala { get => sala; set => sala = value; }
        internal Seans Seans { get => seans; set => seans = value; }
        public void ZajmijMiejsce( int miejsce)
        {
            if (plan[ miejsce-1] == 1)
                throw new Miejsce_juz_zajete("Miejsce jest już zajęte");
            else
                plan[miejsce-1] = 1;
        }
    }
}
