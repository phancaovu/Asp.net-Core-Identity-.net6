using System.ComponentModel.DataAnnotations;

namespace User.Management.API.Models.Authentication.SignUp
{
    public class ResetPassword
    {

        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;


        [Required]
        public string? Password { get; set; } = null!;

        [Compare("Password", ErrorMessage =" The password confirm does not match? ")]
        public string? ConfirmPassword { get; set; } = null!;



    }
}
