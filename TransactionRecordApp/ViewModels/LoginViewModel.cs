//DRASTI PATEL
//QUIZ 05
//MARCH 31, 2025 

//Snippet Provided

using System.ComponentModel.DataAnnotations;

namespace TransactionRecordApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string? Password { get; set; }

        public string? ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
