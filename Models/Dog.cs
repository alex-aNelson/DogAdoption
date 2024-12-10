using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class Dog
    {
        public int DogID { get; set; } // DogID is required and non-nullable

        [Required]
        [StringLength(100, ErrorMessage = "Dog name cannot exceed 100 characters.")]
        public string DogName { get; set; } = string.Empty; // DogName is required and cannot be null

        [Required]
        [Range(1, 30, ErrorMessage = "Dog age must be between 1 and 30 years.")]
        public int DogAge { get; set; } // DogAge is required and non-nullable

        [Required]
        [Range(1, 200, ErrorMessage = "Dog weight must be between 1 and 200 kg.")]
        public decimal DogWeight { get; set; } // DogWeight is required and non-nullable

        [Required]
        [StringLength(100, ErrorMessage = "Dog breed description cannot exceed 100 characters.")]
        public string DogBreed { get; set; } = string.Empty; // DogBreed is required and cannot be null

        [Required]
        public bool IsMale { get; set; } // IsMale is required and non-nullable

        [Required]
        public bool IsVaccinated { get; set; } // IsVaccinated is required and non-nullable

        [Required]
        public bool IsNeutered { get; set; } // IsNeutered is required and non-nullable

        [StringLength(100, ErrorMessage = "Temperament description cannot exceed 100 characters.")]
        public string Temperament { get; set; } = string.Empty; // Temperament is now non-nullable
    }
}
