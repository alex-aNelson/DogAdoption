using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class Messages
    {
        [Key]
        public int MessageID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Header cannot exceed 50 characters.")]
        public string Header { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Message cannot exceed 500 characters")]
        public string Contents { get; set; }

    }

}

