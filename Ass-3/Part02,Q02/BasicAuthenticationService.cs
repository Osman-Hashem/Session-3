namespace Ass_3.Part02_Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {


        public string Name = "User01";
        public string Password = "123";
        public string UserName = "Usre02";
        public string Role = "Password";

        public void AuthenticateUser(string Name, string Password)
        {
            if (Name == this.Name && Password == this.Password)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public void AuthorizeUser(string UserName, string Role)
        {
            if (UserName == this.UserName && Role == this.Role)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
