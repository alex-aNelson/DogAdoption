using DogAdoption.Data;
using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Components.Attributes
{
    public class UnderageAttribute : ValidationAttribute
    {
        private readonly int _minimumAge = 18;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || !(value is DateTime))
                return new ValidationResult("Date is required.");

            var dbContext = (DogAdoptionContext)validationContext.GetService(typeof(DogAdoptionContext));

            //Getting the date from the user
            var dob = (DateTime)value;

            //Calculating the age
            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            //Checks to see if the user meets the minimum age
            if (age < _minimumAge)
                return new ValidationResult($"You must be at least {_minimumAge} years old");

            //The user is 18 or older
            return ValidationResult.Success;
        }
    }
}
