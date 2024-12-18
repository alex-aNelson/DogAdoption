using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using DogAdoption.Data;
using System.Text.RegularExpressions;

namespace DogAdoption.Components.Attributes
{
    public class UsernameRequirementsAttribute : ValidationAttribute
    {
        //Makes sure the username has at least 10 characters
        private const string UsernamePattern = @"^[a-zA-Z0-9@_]{10,}$";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //Unique Username already covers a null entry

            var username = value.ToString();

            // Check if the username matches the regex pattern
            if (!Regex.IsMatch(username, UsernamePattern))
            {
                return new ValidationResult("Username must be at least 10 characters long and contain only letters, numbers, '@', or '_'.");
            }

            return ValidationResult.Success;
        }
    }
}
