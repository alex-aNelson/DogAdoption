using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DogAdoption.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        [Required]
        public string CardType { get; set; } // "Debit" or "Credit"

        [Required]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits.")]
        public string CardNumber { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Security code must be 3 or 4 digits.")]
        public string SecurityCode { get; set; }
    }


}