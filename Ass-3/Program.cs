using System.Data;
using System.Drawing;
using System.Xml.Linq;
using Ass_3.Part02_Q01;
using Ass_3.Part02_Q02;
using Ass_3.Part02_Q03;

namespace Ass_3
{
    internal class Program
    {
        static void Main()
        {

            #region Part 01 : 

            #region Q01 : 
            //// What is the primary purpose of an interface in C# ?

            // B)  To define a blueprint for a class
            #endregion

            #region Q02 : 
            // Which of the following is NOT a valid access modifier for interface members in C#?

            // A) Private 
            #endregion

            #region Q03 : 
            // Can an interface contain fields in C#?

            // B) No
            #endregion

            #region Q04 : 
            // In C#, can an interface inherit from another interface?

            //B) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q05 : 
            // Which keyword is used to implement an interface in a class in C#?

            // D) implements
            #endregion

            #region Q06 : 
            // Can an interface contain static methods in C#?

            // A) Yes
            #endregion

            #region Q07 : 
            // In C#, can an interface have explicit access modifiers for its members?

            // B) ) No, all members are implicitly public
            #endregion

            #region Q08 : 
            // What is the purpose of an explicit interface implementation in C#?

            // A) ) To hide the interface members from outside access
            #endregion

            #region Q09 : 
            // In C#, can an interface have a constructor?

            // B) No, interfaces cannot have constructors
            #endregion

            #region Q10 : 
            // How can a C# class implement multiple interfaces?

            // C) By separating interface names with commas

            #endregion

            #endregion

            #region Part 02 : 

            #region Q01 : 

            /* 
             Define an interface named IShape with a property Area and a method DisplayShapeInfo. 
            Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
            Implement these interfaces in classes Circle and Rectangle. 
            Test your implementation by creating instances of both classes and displaying their shape information.
             */



            //ICircle circle = new Circle { Radius = 8 };

            //circle.DisplayShapeInfo();

            //Console.WriteLine();

            //IRectangle rectangle = new Part02_Q01.Rectangle { Length = 8, Width = 7 };
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region Q02 : 


            /*
             In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. 
            The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
             */


            //IAuthenticationService service = new BasicAuthenticationService();


            //service.AuthenticateUser("User01", "1233");

            //Console.WriteLine();

            //service.AuthorizeUser("Usre02", "Password");

            #endregion

            #region Q03 : 
            /*
             we define the INotificationService interface with a method SendNotification 
            that takes a recipient and a message as parameters.
             */
            //EmailNotificationService email = new EmailNotificationService();

            //SmsNotificationService sms = new SmsNotificationService();

            //PushNotificationService push = new PushNotificationService();

            //INotificationService service01 = email ;
            //INotificationService service02 = sms ;
            //INotificationService service03 = push ;


            //service01.SendNotification("Osman@g.c", "Welcom");

            //service02.SendNotification("Osman", "Welcom");

            //service03.SendNotification("PUSH", "Welcom");

            #endregion

            #endregion

        }
    }
}
