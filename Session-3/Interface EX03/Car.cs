using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.Interface_EX03
{
    internal class Car : IMoveable
    {
        public int Speed { get ; set ; }

        public void Backward()
        {
            Console.WriteLine("Car IMovable Backward");
        }

        public void Fowrward()
        {
            Console.WriteLine("Car IMovable Fowrward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMovable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMovable Right");
        }
    }
}
