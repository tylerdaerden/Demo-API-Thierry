using F23L034_GestContact.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Queries
{
    public class LoginQuery : IQueryDefinition<Utilisateur?>
    {
        public string Email { get; init; }
        public string Passwd { get; init; }

        public LoginQuery(string email, string passwd)
        {
            Email = email;
            Passwd = passwd;
        }
    }
}
