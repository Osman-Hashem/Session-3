namespace Ass_3.Part02_Q02
{
    internal interface IAuthenticationService
    {
        void AuthenticateUser(string Name, string Password);
        void AuthorizeUser(string UserName, string Role);

    }
}
