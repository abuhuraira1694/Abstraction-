using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cs_409
{
    public class yaris : car
    {
        public override void running()
        {
            Console.WriteLine("car is running");

        }
        public override void stop()
        {
            Console.WriteLine("car is stop moving");
        }
    }
}
