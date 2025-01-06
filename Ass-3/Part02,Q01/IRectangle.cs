using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_3.Part02_Q01
{
    internal interface IRectangle : IShape
    {
        double Width { get; set; }
        double Length { get; set; }
        double Area { get; }
    }
}
