namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "emailRequired")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
