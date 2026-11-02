using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModelscs
    {
        [Required(ErrorMessage = "Podaj nazwe użytkownika!")]
        [MinLength(8, ErrorMessage ="Nazwa uzytkownika musi miec minimum 8 znaków")]
        [MaxLength(8, ErrorMessage = "Nazwa uzytkownika nie moze miec wiecej niz 24 znakow")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Podaj adres email!")]
        [EmailAddress(ErrorMessage ="Nieprawidlowy adres email!")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Podaj hasło!")]
        [MinLength(8, ErrorMessage ="Hasło musi miec minimum 8 znaków!")]
        public string Password { get; set; } = "";
        [Required(ErrorMessage = "Podaj Potwierdz hasło!")]
        [Compare(nameof(Password), ErrorMessage ="Hasła nie są takie same. ")]
        public string ConfirmPassword { get; set; } = "";
        [Range(typeof(bool), "true", "true", ErrorMessage ="Musisz zaakceptowac")]
        public bool AcceptTerms { get; set; }
    }
}
