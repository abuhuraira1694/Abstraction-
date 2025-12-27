using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    public class cat : animal
    {
               public override void eat()
        {
            Console.WriteLine("cats also eat meat.");
        }
        public override void move()
        {
            Console.WriteLine("cats walk on four legs");
        }
        public override void sleep()
        {
            Console.WriteLine("cats sleep a lot");
        }
        public  void sound()
        {
            Console.WriteLine("cats meow softly");
        }

    }
}
