using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_GestContact.Api.Models.Entities
{
    public class Contact
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public DateTime Anniversaire { get; init; }
        public string? Tel { get; init; }
        public Contact(int id, string nom, string prenom, string email, DateTime anniversaire, string? tel)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Anniversaire = anniversaire;
            Tel = tel;
        }
    }
}
