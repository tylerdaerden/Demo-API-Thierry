using F23L034_GestContact.Api.Models.Entities;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Queries
{
    public class GetContactsQuery : IQueryDefinition<IEnumerable<Contact>>
    {
        public int UtilisateurId { get; init; }

        public GetContactsQuery(int utilisateurId)
        {
            UtilisateurId = utilisateurId;
        }
    }
}
