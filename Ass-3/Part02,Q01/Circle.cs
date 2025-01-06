using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_3.Part02_Q01
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set ; }

        double IShape.Area { get ; set ; }
        public double Area => Math.PI * Math.Pow(Radius, 2);

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius} :\nAnd Area = {Area}");
        }
    }
}
