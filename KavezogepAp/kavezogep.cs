using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepAp
{
    internal class kavezogep
    {
        private int Vizkeszlet;

        public void VizTolt(int ml)
        {
            if (ml <0)
            {
                Vizkeszlet = 0;
            }
            else Vizkeszlet += ml;
        }
        public void KaveFozes()
        {
            if(Vizkeszlet >= 150)
            {
                Vizkeszlet -= 150;
            }
            else
            {
                Console.WriteLine("Nem áll elég víz rendelkezésre a főzéshez.");
            }
        }
    }
}
