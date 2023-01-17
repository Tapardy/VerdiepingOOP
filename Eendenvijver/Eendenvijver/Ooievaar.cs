using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Ooievaar
    {
        private Geslacht Geslacht;
        private List<Kikker> gegetenKikkers = new List<Kikker>();

        public List<Kikker> Kikkers
        {
            get { return gegetenKikkers; }
        }

        public Ooievaar()
        {
            Random rndGeslacht = new Random();
            for (int i = 0; i <= 1; i++)
            {
                Geslacht = (Geslacht)rndGeslacht.Next(3);
            }
            GetGeslacht();
        }

        public void GegetenKikker(Kikker kikker)
        {

            if (this.Geslacht == kikker.Geslacht)
            {
                gegetenKikkers.Add(kikker);
            }
        }

        public Geslacht GetGeslacht()
        {
            return Geslacht;
        }
    }
}
