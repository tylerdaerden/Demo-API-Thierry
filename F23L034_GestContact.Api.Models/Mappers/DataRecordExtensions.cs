using F23L034_GestContact.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_GestContact.Api.Models.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Utilisateur ToUtilisateur(this IDataRecord dataRecord)
        {
            return new Utilisateur((int)dataRecord["Id"], (string)dataRecord["Nom"], (string)dataRecord["Prenom"], (string)dataRecord["Email"]);
        }

        internal static Contact ToContact(this IDataRecord dataRecord)
        {
            return new Contact((int)dataRecord["Id"], 
                (string)dataRecord["Nom"], 
                (string)dataRecord["Prenom"], 
                (string)dataRecord["Email"], 
                (DateTime)dataRecord["Anniversaire"],
                dataRecord["Tel"] as string);
        }
    }
}
