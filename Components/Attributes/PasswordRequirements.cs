using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using DogAdoption.Data;
using System.Text.RegularExpressions;

namespace DogAdoption.Components.Attributes
{
    public class PasswordRequirementsAttribute : ValidationAttribute
    {
        //Makes sure the password has at least 10 characters and has a special character
        private const string PasswordPattern = @"^(?=.*[!@#$%^&*(),.?""':{}|<>])(?=.*[a-zA-Z0-9]).{10,}$";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Check if the input value is null
            if (value == null)
                return new ValidationResult("Password is required.");

            var password = value.ToString();

            // Check if the username matches the regex pattern
            if (!Regex.IsMatch(password, PasswordPattern))
            {
                return new ValidationResult("Password must be at least 10 characters long and include at least one special character");
            }

            return ValidationResult.Success;
        }
    }
}
