using System.ComponentModel.DataAnnotations;

namespace Mission06_Mitton.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Primary Key

        // --- NEED SPREADSHEET COLUMNS HERE ---
        // (e.g., Title, Year, Director, Category? I will need these from you!)
        // [Required]
        // public string Title { get; set; }

        [Required]
        public string Rating { get; set; } // Will be handled via a dropdown in the view

        public bool Edited { get; set; } // Yes/No boolean

        public string? LentTo { get; set; } // Nullable because it is not required

        [MaxLength(25, ErrorMessage = "Notes must be limited to 25 characters.")]
        public string? Notes { get; set; } // Nullable because it is not required
    }
}