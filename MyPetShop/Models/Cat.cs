using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThirdASPNET.Models
{
    public class Cat : Pet
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Cat Breed")]
        [MinLength(3)]
        public string? Breed { get; set; }
    }
}