using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Commands
{
    public class AddContactCommand : ICommandDefinition
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public DateTime Anniversaire { get; init; }
        public string? Tel { get; init; }
        public int UtilisateurId { get; init; }

        public AddContactCommand(string nom, string prenom, string email, DateTime anniversaire, string? tel, int utilisateurId)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Anniversaire = anniversaire;
            Tel = tel;
            UtilisateurId = utilisateurId;
        }
    }
}
