using F23L034_GestContact.Api.Models.Commands;
using F23L034_GestContact.Api.Models.Entities;
using F23L034_GestContact.Api.Models.Queries;
using F23L034_GestContact.Api.Models.Repositories;
using F23L034_GestContact.Api.Models.Services;
using System.Data.Common;
using System.Data.SqlClient;
//Manque ci dessous le package de thierry
//using Tools.Cqs.Commands;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CONNECTION_STRING = "Data Source=TOURPCDANY\\DATAVIZ;Initial Catalog=F23L034_GestContact_Cqs;Integrated Security=True";
            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IAuthRepository authRepository = new AuthService(dbConnection);

            //    ICommandResult result = authRepository.Execute(new RegisterCommand("Morre", "Thierry", "thierry.morre@cognitic.be", "Test1234="));
            //    Console.WriteLine(result.IsSuccess);
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IAuthRepository authRepository = new AuthService(dbConnection);

            //    Utilisateur? utilisateur = authRepository.Execute(new LoginQuery("thierry.morre@cognitic.be", "Test1234="));
            //    Console.WriteLine(utilisateur is not null);
            //    if(utilisateur is not null)
            //        Console.WriteLine($"{utilisateur.Id} : {utilisateur.Nom} {utilisateur.Prenom} ('{utilisateur.Email}')");
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    ICommandResult result = authRepository.Execute(new AddContactCommand("Lorent", "Steve", "steve.lorent@bstorm.be", new DateTime(1984, 06, 28), null, 1));                
            //    Console.WriteLine(result.IsSuccess);
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    IEnumerable<Contact> contacts = authRepository.Execute(new GetContactsQuery(1));
            //    Console.WriteLine(contacts.Count());

            //    foreach (Contact contact in contacts) 
            //    {
            //        Console.WriteLine($"{contact.Id} {contact.Nom} {contact.Prenom} {contact.Email} {(contact.Tel ?? "Null")}");
            //    }
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    Contact? contact = authRepository.Execute(new GetContactQuery(1, 1));
            //    Console.WriteLine(contact is not null);

            //    if (contact is not null)
            //    {
            //        Console.WriteLine($"{contact.Id} {contact.Nom} {contact.Prenom} {contact.Email} {(contact.Tel ?? "Null")}");
            //    }
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    ICommandResult result = authRepository.Execute(new DeleteContactCommand(3, 1));
            //    Console.WriteLine(result.IsSuccess);
            //    if(result.IsFailure)
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    ICommandResult result = authRepository.Execute(new UpdateContactCommand(3, "Strimelle", "Aurélien", "aurelien.strimelle@bstorm.be", new DateTime(2000, 06, 16), null, 1));
            //    Console.WriteLine(result.IsSuccess);
            //    if (result.IsFailure)
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}

            //using (DbConnection dbConnection = new SqlConnection(CONNECTION_STRING))
            //{
            //    IContactRepository authRepository = new ContactService(dbConnection);
            //    ICommandResult result = authRepository.Execute(new UpdateContactPhoneCommand(3, null, 1));
            //    Console.WriteLine(result.IsSuccess);
            //    if (result.IsFailure)
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}
        }
    }
}