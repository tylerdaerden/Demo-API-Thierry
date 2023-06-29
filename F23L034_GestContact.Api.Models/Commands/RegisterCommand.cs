using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Commands
{
    public class RegisterCommand : ICommandDefinition
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string Passwd { get; init; }

        public RegisterCommand(string nom, string prenom, string email, string passwd)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Passwd = passwd;
        }
    }
}
