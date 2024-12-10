using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class AdoptionApplication
    {
        [Key]
        public int ApplicationID { get; set; } // Primary key for the AdoptionApplication entity

        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; } // Foreign key referencing the User entity

        [Required]
        [ForeignKey("Dog")]
        public int DogID { get; set; } // Foreign key referencing the Dog entity

        [StringLength(100, ErrorMessage = "Phone number cannot exceed 100 characters.")]
        public string? PhoneNumber { get; set; } // Optional, max length 100

        [StringLength(250, ErrorMessage = "Extra information cannot exceed 250 characters.")]
        public string? ExtraInformation { get; set; } // Optional, max length 250

        public bool HasOtherPets { get; set; } // Optional, nullable
        public bool HasChildrenUnderTwelve { get; set; } // Optional, nullable

        // Navigation properties
        public User User { get; set; } // Navigation property for User
        public Dog Dog { get; set; } // Navigation property for Dog
    }
}
