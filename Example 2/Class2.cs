using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    public class lion:animal
    {
        public override void eat()
        {
            Console.WriteLine("lions eat meat");
        }
        public override void move()
        {
            Console.WriteLine("Lions walk on four legs");
        }
        public override void sleep()
        {
            Console.WriteLine("lions sleep less because they have to prey");
        }
        public  void sound()
        {
                       Console.WriteLine("lions roar loudly");

        }
    }
}
