using System.Collections;

namespace Session_3
{

    class EmployeeComparerNameLenght : IComparer
    {


        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.Name.Length > Y.Name.Length) return 1;
            else if (X.Name.Length < Y.Name.Length) return -1;
            else return 0;

        }
    }

    class EmployeeComparerSalary : IComparer
    {


        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.Salary > Y.Salary) return 1;
            else if (X.Salary < Y.Salary) return -1;
            else return 0;

        }
    }

    internal class Employee : ICloneable, IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


        public Employee()
        {

        }

        // Copy Constructor 
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }

        public object Clone()
        {
            return new Employee(this); // Sugar →
            //return new Employee () { Id = this.Id, Salary = this.Salary , Age = this.Age , Name = this.Name};
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary} ";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;
            if (this.Age > e.Age) return 1;
            else if (this.Age < e.Age) return -1;
            else return 0;
        }
    }
}
