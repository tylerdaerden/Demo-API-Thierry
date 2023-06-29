using F23L034_GestContact.Api.Models.Commands;
using F23L034_GestContact.Api.Models.Entities;
using F23L034_GestContact.Api.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Repositories
{
    public interface IContactRepository :
        ICommandHandler<AddContactCommand>,
        IQueryHandler<GetContactsQuery, IEnumerable<Contact>>,
        IQueryHandler<GetContactQuery, Contact?>,
        ICommandHandler<DeleteContactCommand>,
        ICommandHandler<UpdateContactCommand>,
        ICommandHandler<UpdateContactPhoneCommand>
    {
    }
}
