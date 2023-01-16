using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    public class Eend
    {
        private Geslacht Geslacht;

        public Eend()
        { //premade eenden
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                Geslacht = (Geslacht)rnd.Next(3);
            }
            GetGeslacht();
        }

        public Eend(Geslacht geslacht)
        {
            Geslacht = geslacht;
        }
        
        public Geslacht GetGeslacht()
        {
            return Geslacht;
        }
    }
}
