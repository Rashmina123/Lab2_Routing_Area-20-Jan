using System.ComponentModel.DataAnnotations;

namespace Lab2_Routing_Area_20_Jan.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Enter UserName")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
