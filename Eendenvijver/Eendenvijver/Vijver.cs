using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Vijver
    {
        private Eend[] eenden = new Eend[6];
        private Kikker[] kikkers = new Kikker[10];
        private Ooievaar[] ooievaar = new Ooievaar[1];
         
        public Vijver() 
        {
            for (int i = 0; i < eenden.Length; i++)
            {
                eenden[i] = new Eend();
            }

            for(int j = 0; j <kikkers.Length; j++)
            {
                kikkers[j] = new Kikker();
            }

            for (int k = 0; k < ooievaar.Length; k++)
            {
                ooievaar[k] = new Ooievaar();
            }
        }

        public Eend[] ChangeGeslacht(int selectedEend, Geslacht geslacht)
        {
            eenden[selectedEend] = new Eend(geslacht); //nieuw geslacht meegeven
            return eenden;
        }

        public Eend[] GetEend() 
        { 
            return eenden; 
        }

        public Kikker[] GetKikkers() 
        { 
            return kikkers; 
        }

        public Ooievaar[] GetOoievaar()
        {
            return ooievaar;
        }
    }
}
