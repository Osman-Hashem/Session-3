using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.Interface_EX03
{
    internal interface IFlyable 
    {
        int Speed { get; set; }
        void Fowrward();
        void Backward();
        void Left();
        void Right();

    }
}
