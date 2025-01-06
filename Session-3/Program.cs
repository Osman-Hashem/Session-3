namespace Session_3
{

    // 1- Class 
    // 2- Struct
    // 3- Enum 
    // 4- Interfaces 



    internal class Program
    {

        //static void Print10Number (SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10 ; i++)
        //    {
        //        Console.Write ($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}

        //static void Print10Number (SeriesByThree series)
        //{
        //    for (int i = 0; i < 10 ; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}

        //static void Print10Number(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}

        //---------------------------------------------

        //static void Print10Number(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}


        static void Main()
        {

            #region Interface Ex01
            // Interfaces : References Type 
            // Code Contract Between The Developer Who Write It And The Developer Who Use It [Implementation]


            //IMyType myType = new IMyType();

            // NOTE : Can't Create Object From Any Interfaces 

            //-------------------------

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();

            //myType.Print(); //

            //IMyType myType;
            //// Ref --> Can Refer To Object From Any Class Witch Implement The Interface 'IMyType'

            //myType = new MyType();

            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.Print(); 
            #endregion

            #region Interface EX02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByFour = new SeriesByFour();

            //Print10Number(seriesByTwo);
            //Print10Number(seriesByThree);
            //Print10Number(seriesByFour);

            //---------------------------------

            //int[] Numbers = { 7, 8, 9, 1, 2, 3, 4, 6, 5 };

            //Array.Sort(Numbers);

            //foreach (int item in Numbers)
            //{
            //    Console.Write($"{item} ");
            //}

            //---------------------------------

            //Employee[] employee = new Employee[3]
            //{
            //    new Employee() {Id = 1 , Name = "Ahmed" , Age = 30 , Salary = 1200} , 
            //    new Employee() {Id = 2 , Name = "Omar" , Age = 27 , Salary = 11000} , 
            //    new Employee() {Id = 3 , Name = "Amr" , Age = 28 , Salary = 13000} 
            //};

            //Array.Sort(employee);

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine($"{emp}");
            //} 
            #endregion

            #region Interface EX03
            //Car car = new Car();    

            //car.Speed = 100;
            //car.Fowrward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;

            //moveable.Backward();

            //IFlyable flyable = airplane;

            //flyable.Fowrward(); 
            #endregion

            #region Shallow Copy Vs Deep Copy
            // Shallow Copy Vs Deep Copy :

            // 1- Shallow Copy :

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = Arr01; // Shallow Copy 
            //// Copy Idintity 
            //// { 1, 2, 3 } --> Has Two Refernces Arr01 , Arr02 
            //// { 4, 5, 6 } --> UnReachable Object 

            //Console.WriteLine();

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State (Data)

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            //---------------------------------

            // 2- Deep Copy :

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = (int[])Arr01.Clone(); // Deep Copy 
            //// Clone Method Will Copy The Object State Of The caller 
            //// Assign The New Object To The Arr02 , Will Generate NEW Idintity 

            //Console.WriteLine();

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State (Data)

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            //-----------------------------------------

            // Shallow Copy Vs Deep Copy :

            // 1- Shallow Copy :

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Ziad" , "Adel" , "Amr" };


            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");  
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = Arr01; // Shallow Copy 
            //// Copy Idintity 
            //// { 1, 2, 3 } --> Has Two Refernces Arr01 , Arr02 
            //// { 4, 5, 6 } --> UnReachable Object 

            //Console.WriteLine();

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State (Data)

            //Arr02[0] += "Ahmed Amain";

            //Console.WriteLine(Arr01[0]);

            //---------------------------------

            // 2- Deep Copy :

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = (string[])Arr01.Clone(); // Deep Copy 
            //// Clone Method Will Copy The Object State Of The caller 
            //// Assign The New Object To The Arr02 , Will Generate NEW Idintity 

            //Console.WriteLine();

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State (Data)

            //Arr02[0] = "Osman";

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]); 
            #endregion

            #region Built-In Interface Icloneable 
            //Employee E01 = new Employee() { Id = 1  , Name = "Ahmed" , Age = 29 , Salary = 12000};
            //Employee E02 = new Employee() { Id = 2  , Name = "Amr" , Age = 32 , Salary = 11000};

            ////E02 = E01; // Shallow Copy 
            //E02 = (Employee)E01.Clone(); // Deep Copy 
            //E02 = new  Employee (E01); //  Deep Copy Copy Constructor 

            //E01.Salary = 5;

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion

            #region Built-In Interface ICompereable
            //Employee[] employee = new Employee[3]
            //{
            //    new Employee() {Id = 1 , Name = "Ahmed" , Age = 30 , Salary = 1200} ,
            //    new Employee() {Id = 2 , Name = "Omar" , Age = 27 , Salary = 11000} ,
            //    new Employee() {Id = 3 , Name = "Amr" , Age = 28 , Salary = 13000}
            //};

            //Array.Sort(employee);

            ////int X = employee[1].CompareTo(employee[0]);
            //// +ve : Caller Greater Than Paremeter 
            //// -ve : Caller Less Than Paremeter 
            ////  0  : Caller Equal Paremeter 

            ////Console.WriteLine(X);

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            //Employee[] employee = new Employee[3]
            //{
            //    new Employee() {Id = 1 , Name = "Ahmed" , Age = 30 , Salary = 12000} ,
            //    new Employee() {Id = 2 , Name = "Omar" , Age = 27 , Salary = 11000} ,
            //    new Employee() {Id = 3 , Name = "Amr" , Age = 28 , Salary = 13000}
            //};

            ////Array.Sort(employee ,new EmployeeComparerSalary());   

            ////Array.Sort(employee ,new EmployeeComparerNameLenght());


            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}

        }
    }
}
