using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
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
