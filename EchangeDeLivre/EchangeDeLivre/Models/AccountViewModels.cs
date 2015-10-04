using EchangeDeLivre.Ressources;
using System.ComponentModel.DataAnnotations;

namespace EchangeDeLivre.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Nom d’utilisateur")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau mot de passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le nouveau mot de passe")]
        [Compare("NewPassword", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Mail", ResourceType = typeof(Ressources.Resources))]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Ressources.Resources))]
        public string Password { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(Ressources.Resources))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Display(Name = "UserCategory", ResourceType = typeof(Ressources.Resources))]
        public string UserCategorie { get; set; }

        [Display(Name = "Nom d’utilisateur")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Mail", ResourceType = typeof(Ressources.Resources))]
        public string Mail { get; set; }

        [Display(Name = "Telephone", ResourceType = typeof(Ressources.Resources))]
        public string PhoneNumber { get; set; }

        //[Required]
        [Display(Name = "CoopName", ResourceType = typeof(Ressources.Resources))]
        public string CooperativeName { get; set; }

        //[Required]
        [Display(Name = "CoopAdress", ResourceType = typeof(Ressources.Resources))]
        public string CooperativeNameAdress { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Ressources.Resources))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Ressources.Resources))]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

    }
}
