using F23L034_GestContact.Api.Models.Commands;
using F23L034_GestContact.Api.Models.Entities;
using F23L034_GestContact.Api.Models.Mappers;
using F23L034_GestContact.Api.Models.Queries;
using F23L034_GestContact.Api.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;
using Tools.Cqs.Commands;

namespace F23L034_GestContact.Api.Models.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly DbConnection _dbConnection;

        public AuthService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public ICommandResult Execute(RegisterCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    _dbConnection.ExecuteNonQuery("CSP_Register", true, command);
                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }            
        }

        public Utilisateur? Execute(LoginQuery query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                return _dbConnection.ExecuteReader("CSP_Login", (dr) => dr.ToUtilisateur(), true, query).SingleOrDefault();                
            }
        }
    }
}
