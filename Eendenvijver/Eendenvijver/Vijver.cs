using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Vijver
    {
        public Eend[] eenden = new Eend[6];
        public string[] kikkers = new string[5];

        public Vijver() 
        {
            for (int i = 0; i < eenden.Length; i++)
            {
                eenden[i] = new Eend();
            }
        }
        public Eend[] ChangeGeslacht(int selectedEend, Geslacht geslacht)
        {
            eenden[selectedEend] = new Eend(geslacht);
            return eenden;
        }

        public Eend[] GetEend() 
        { 
            return eenden; 
        }
    }
}
