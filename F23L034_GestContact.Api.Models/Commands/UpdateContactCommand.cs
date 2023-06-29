using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Commands
{
    public class UpdateContactCommand : ICommandDefinition
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public DateTime Anniversaire { get; init; }
        public string? Tel { get; init; }
        public int UtilisateurId { get; init; }
        public UpdateContactCommand(int id, string nom, string prenom, string email, DateTime anniversaire, string? tel, int utilisateurId)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Anniversaire = anniversaire;
            Tel = tel;
            UtilisateurId = utilisateurId;
        }
    }
}
