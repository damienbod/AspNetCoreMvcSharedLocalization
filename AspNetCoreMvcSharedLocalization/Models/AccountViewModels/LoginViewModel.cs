namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class LoginViewModel
    {
        [Required(ErrorMessage = "emailRequired")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "passwordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
