using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cs_409
{
    class program
    {
        static void Main()
        {
            yaris y = new yaris();
            y.start();
            y.running();
            y.stop();
            Console.ReadLine();


        }
    }
}
