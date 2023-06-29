using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Commands
{
    public class DeleteContactCommand : ICommandDefinition
    {
        public int Id { get; init; }
        public int UtilisateurId { get; init; }
        public DeleteContactCommand(int id, int utilisateurId)
        {
            Id = id;
            UtilisateurId = utilisateurId;
        }
    }
}
