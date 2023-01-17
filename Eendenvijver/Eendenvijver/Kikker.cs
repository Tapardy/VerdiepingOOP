using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Kikker
    {
        public Geslacht Geslacht { get; private set; }
        public int kikkernummer { get; private set; }

        public Kikker()
        {
            Random rndGeslacht = new Random();
            for (int i = 0; i <= 1; i++)
            {
                Geslacht = (Geslacht)rndGeslacht.Next(3);
            }
            GetGeslacht();
        }
        public Kikker(Geslacht geslacht, int kikkernummer)
        {
            this.Geslacht = geslacht;
            this.kikkernummer = kikkernummer;
        }
        

        public Geslacht GetGeslacht()
        {
            return Geslacht;
        }
    }
}
