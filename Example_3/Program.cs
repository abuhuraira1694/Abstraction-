using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zoo a = new zoo();
            a.eat();
            a.move();
            a.sleep();
            a.sound();
        }
    }
}
