using F23L034_GestContact.Api.Models.Commands;
using F23L034_GestContact.Api.Models.Entities;
using F23L034_GestContact.Api.Models.Queries;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Repositories
{
    public interface IAuthRepository :
        ICommandHandler<RegisterCommand>,
        IQueryHandler<LoginQuery, Utilisateur?>
    {
    }
}
