using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class AdoptionPosting
    {
        [Key]
        public int AdoptionPostingID { get; set; } // Primary key for the AdoptionPosting

        // Foreign key referencing the Dog entity
        [Required]
        [ForeignKey("Dog")]
        public int DogID { get; set; } // Foreign key that links this posting to a dog

        // Navigation property for the Dog entity
        public Dog Dog { get; set; } // Navigation property to access the Dog's details

        // Optional description for the adoption posting
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        // Price for the dog in this adoption posting
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal Price { get; set; } // Price of the dog in the adoption posting

    }
}
