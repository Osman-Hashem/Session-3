namespace Session_3.Interface_EX01
{
    internal class MyType : IMyType, IComparable, ICloneable  // [:] --> Implement
    {
        public double Salary { get ; set ; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void MyFun()
        {
            Console.WriteLine("Hello World :)");
        }
    }
}
