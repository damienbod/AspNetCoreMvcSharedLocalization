using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "emailRequired")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "passwordRequired")]
        [StringLength(100, ErrorMessage = "passwordStringLength", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "confirmPasswordNotMatching")]
        public string ConfirmPassword { get; set; }
    }
}
