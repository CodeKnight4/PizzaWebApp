using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThirdASPNET.Models
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MinLength(2)]
        [Display(Name = "Pet Name")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "Pet Colour")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string? Colour { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Sound")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string? Sound { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Sound Type")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string? SoundType { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - DateOfBirth.Year;
                if (now < DateOfBirth.AddYears(age)) age--;
                return age;
            }
        }

        public string? MakeSound()
        {
            return Sound;
        }

        public virtual string? MakeSoundType()
        {
            return SoundType;
        }
    }
}
