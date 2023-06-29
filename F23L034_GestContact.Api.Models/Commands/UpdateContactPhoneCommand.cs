using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Commands
{
    public class UpdateContactPhoneCommand : ICommandDefinition
    {
        public int Id { get; init; }
        public string? Tel { get; init; }
        public int UtilisateurId { get; init; }
        public UpdateContactPhoneCommand(int id, string? tel, int utilisateurId)
        {
            Id = id;
            Tel = tel;
            UtilisateurId = utilisateurId;
        }
    }
}
