using DogAdoption.Components.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class User
    {
        public int UserID { get; set; } // UserID is required and non-nullable

        [Required]
        [StringLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        [UniqueUsername]
        [UsernameRequirements]
        public string Username { get; set; } = null!; // Username is required and has a 100-character limit

        [Required]
        [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
        [PasswordRequirements]
        public string Password { get; set; } = null!; // Password is required and has a 100-character limit

        public bool IsAdmin { get; set; } = false; // Defaults to false if not provided

        

        // Add a DateOfBirth property
        [Required]
        [Underage]
        public DateTime DateOfBirth { get; set; }
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
