using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepApp
{
    internal class Kavezogep
    {
        private int vizKeszletMl;

        public void VizTolt( int ml) 
        {
            if (ml < 0)
            {
                Console.WriteLine("A megadott érték nem lehet negatív.");
            }
        }
    }
}
