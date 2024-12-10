using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class User
    {
        public int UserID { get; set; } // UserID is required and non-nullable

        [Required]
        [StringLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        public string Username { get; set; } = null!; // Username is required and has a 100-character limit

        [Required]
        [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
        public string Password { get; set; } = null!; // Password is required and has a 100-character limit

        public bool IsAdmin { get; set; } = false; // Defaults to false if not provided

        // Add a DateOfBirth property
        [Required]
        public DateTime DateOfBirth { get; set; }

        // Calculated age property
        [Range(18, int.MaxValue, ErrorMessage = "You must be at least 18 years old.")]
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        // Optional: Custom validation to check if the user is at least 18 years old
        public bool IsOver18
        {
            get
            {
                return Age >= 18;
            }
        }
    }
}
