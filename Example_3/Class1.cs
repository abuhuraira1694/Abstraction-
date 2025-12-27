using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    public class zoo:bird,animal
    {
        public void eat()
        {
            Console.WriteLine("all animals and birds eat");
        }
        public void sleep()
        {
            Console.WriteLine("all animals and birds sleep");
        }
        public void move()
        {
            Console.WriteLine("animals move on earth and birds can fly in the air");
        }
        public void sound()
        {
            Console.WriteLine("all animals and birds have different sound according to their species");
        }
    }
}
