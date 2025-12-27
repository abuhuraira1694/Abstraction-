using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal a = new lion();
            a.sleep();
            a.move();
            a.eat();
            //a.sound();
            animal c= new cat();
            c.sleep();
            c.eat();
            c.move();
            //a.sound();
        }
    }
}
