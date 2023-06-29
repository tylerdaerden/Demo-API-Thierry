using System.ComponentModel.DataAnnotations;

namespace F23L034_GestContact.Api.Models.Forms
{
#nullable disable
    public class RegisterForm
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Nom { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Passwd { get; set; }
    }
}
