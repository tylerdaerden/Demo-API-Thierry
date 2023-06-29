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
    public class ContactService : IContactRepository
    {
        private readonly DbConnection _dbConnection;

        public ContactService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public ICommandResult Execute(AddContactCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    _dbConnection.ExecuteNonQuery("CSP_AddContact", true, command);
                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }            
        }

        public IEnumerable<Contact> Execute(GetContactsQuery query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                return _dbConnection.ExecuteReader("CSP_GetContacts", (dr) => dr.ToContact(), true, query).ToList();
            }
        }

        public Contact? Execute(GetContactQuery query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                return _dbConnection.ExecuteReader("CSP_GetContact", (dr) => dr.ToContact(), true, query).SingleOrDefault();
            }
        }

        public ICommandResult Execute(DeleteContactCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    int rows = _dbConnection.ExecuteNonQuery("CSP_DeleteContact", true, command);

                    if (rows == 0)
                        return ICommandResult.Failure("Not Found");

                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public ICommandResult Execute(UpdateContactCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    int rows = _dbConnection.ExecuteNonQuery("CSP_UpdateContact", true, command);

                    if (rows == 0)
                        return ICommandResult.Failure("Not Found");

                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public ICommandResult Execute(UpdateContactPhoneCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    int rows = _dbConnection.ExecuteNonQuery("CSP_UpdateContactPhone", true, command);

                    if (rows == 0)
                        return ICommandResult.Failure("Not Found");

                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }
    }
}
