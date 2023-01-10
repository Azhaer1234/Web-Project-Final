using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Web_Project_Final.Models
{
    public class ContectDataModel
    {
        [Key]

        public int ID { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [RegularExpression("[a-z,A-Z]+$", ErrorMessage = "Use Alphabets Only.")]
        [Required(ErrorMessage = "Please enter first name.")]
        [Display(Name = "First Name ")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(40)")]

        [Required(ErrorMessage = "Please enter email.")]
        [Display(Name = "Email ")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [RegularExpression("[0-9]+$", ErrorMessage = "Use Numbers Only.")]
        [Required(ErrorMessage = "Please enter your phone no.")]
        [Display(Name = "Phone No ")]
        public string Phnone { get; set; }
    }
}