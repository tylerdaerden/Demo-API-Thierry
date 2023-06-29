using F23L034_GestContact.Api.Models.Entities;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Queries
{
    public class GetContactQuery : IQueryDefinition<Contact?>
    {
        public int Id { get; init; }
        public int UtilisateurId { get; init; }
        public GetContactQuery(int id, int utilisateurId)
        {
            Id = id;
            UtilisateurId = utilisateurId;
        }
    }
}
