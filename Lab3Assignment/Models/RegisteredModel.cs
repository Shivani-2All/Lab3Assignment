using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3Assignment.Models
{
    public class RegisteredModel
    {
        [Required(AllowEmptyStrings = false)]

        public string Name { get; set; }

        [MinLength(3, ErrorMessage = "Username should be more than 3 digit")]
        public string Username { get; set; }
        public string Email { get; set; }


        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$",
                   ErrorMessage = "Use Mixed Password.")]
        public string Password { get; set; }
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }




        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "ContactNumber must be numeric")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Gender is required")]

        public string Gender { get; set; }

        [Required(ErrorMessage = "You must accepted terms")]
        [Display(Name = "IsAcceptTerms")]
        public bool IsAcceptTerms { get; set; }

    }
}
