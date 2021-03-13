using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OdvozOtpada.Models
{
    public class FiltrirajPretraživanje
    {
        public string tekstPretraživanja { get; set; }

        public string grad { get; set; }

        public string dan { get; set; }

        public string otpad { get; set; }

        public string ulica { get; set; }
    }

    public class PromijeniLozinku
    { 
        public string adminID { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Stara lozinka")]
        [Required(ErrorMessage = "Polje je obavezno.")]
        public string StaraLozinka { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Polje je obavezno.")]
        [Display(Name = "Nova lozinka")]
        [StringLength(100, ErrorMessage = " Lozinka mora biti minimalno {2} znakova dugačka.", MinimumLength = 6)]
        public string NovaLozinka { get; set; }
        [DataType(DataType.Password)]
        [Compare("NovaLozinka", ErrorMessage = "Lozinke se ne poklapaju.")]
        [Required(ErrorMessage = "Polje je obavezno.")]
        [Display(Name = "Ponovite novu lozinku")]
        public string PotvrdiNovuLozinku { get; set; }
    }

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Polje je obavezno.")]
        [Display(Name = "Korisničko ime")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Display(Name = "Zapamti me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [Display(Name = "Korisničko ime")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(100, ErrorMessage = " Lozinka mora biti minimalno {2} znakova dugačka.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Lozinke se ne poklapaju.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Polje je obavezno.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
