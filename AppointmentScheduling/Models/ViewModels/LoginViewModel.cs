using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name="Forget your Password?")]
        public bool RememberMe { get; set; }
    }
}
