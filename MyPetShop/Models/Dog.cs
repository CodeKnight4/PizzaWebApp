using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThirdASPNET.Models
{
    public class Dog : Pet
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Dog Breed")]
        [MinLength(3)]
        public string? Breed { get; set; }
    }
}
