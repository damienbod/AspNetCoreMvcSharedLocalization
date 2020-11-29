namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class ExternalLoginViewModel
    {
        [Required(ErrorMessage = "emailRequired")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
