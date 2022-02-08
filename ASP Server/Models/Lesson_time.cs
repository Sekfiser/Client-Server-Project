using System.ComponentModel.DataAnnotations;


namespace ASP_Server.Models
{
    public class Lesson_time
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Lesson_number { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Lesson_start { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Lesson_finish { get; set; }
    }
}
