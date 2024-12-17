using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using DogAdoption.Data;

namespace DogAdoption.Components.Attributes
{
    public class UniqueUsernameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Check if the input value is null
            if (value == null)
                return new ValidationResult("Username is required.");

            var dbContext = (DogAdoptionContext)validationContext.GetService(typeof(DogAdoptionContext));

            var username = value.ToString();

            // Query the database for existing usernames
            var exists = dbContext.User.Any(u => u.Username == username);

            if (exists)
            {
                return new ValidationResult("Username already exists.");
            }

            return ValidationResult.Success;
        }
    }
}