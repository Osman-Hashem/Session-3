namespace Session_3.Interface_EX01
{
    internal interface IMyType
    {
        // What Can Write Iside The interface : 
        // 1- Signature Of Properties 
        // 2- Signature Of Method [Name , Paremeter , Return Type]
        // 3- Default Implement Methods [Fully Implemented Methods]


        // 2- Signature Of Method [Name , Paremeter , Return Type] : 
        void MyFun();

        // 1- Signature Of Properties 
        double Salary { get; set; }

        // 3- Default Implement Methods [Fully Implemented Methods]
        void Print()
        {
            Console.WriteLine("Default Implement Methods [Fully Implemented Methods]"); 
        }

    }
}
