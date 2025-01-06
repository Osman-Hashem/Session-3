namespace Session_3.Interface_EX03
{
    internal interface IMoveable
    {
        int Speed { get; set; }
        void Fowrward();
        void Backward();
        void Left();
        void Right();
    }
}
