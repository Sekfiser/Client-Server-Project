using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Lesson_type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Type { get; set; }
    }
}
