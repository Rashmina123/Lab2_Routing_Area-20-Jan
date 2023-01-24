//using Microsoft.Build.Framework;

using Lab2_Routing_Area_20_Jan.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Lab2_Routing_Area_20_Jan.Models
{
    public class SignUpModel
    {
       
      
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter UserName ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Correct Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        //[RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password required (1 Uppercase, 1 Number, 1 Special Char and 1 Lowercase Char) with Min Length 8 Chars")]
        public string Password { get; set; }

       
        [Compare("Password", ErrorMessage = "Password should Match with Confirmed Password")]
      
        public string PasswordConfirmed { get; set; }

        //[RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Mobile No")]
        public string? ContactNo { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }
       
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
       
        public bool Terms { get; set; }
        

    }
}
