namespace Session_3.Interface_EX03
{
    internal class Airplane : IMoveable, IFlyable
    {
        int IMoveable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplane IMovable Backward");
        }

        void IMoveable.Fowrward()
        {
            Console.WriteLine("Airplane IMovable Fowrward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane IMovable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplane IMovable Right");
        }



        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane IFlyable Backward");
        }

        void IFlyable.Fowrward()
        {
            Console.WriteLine("Airplane IFlyable Fowrward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane IFlyable Right");
        }
    }
}
