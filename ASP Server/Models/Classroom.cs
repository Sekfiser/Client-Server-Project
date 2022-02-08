using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Frame { get; set; }

        [Required]
        public int? Classroom_number { get; set; }
    }
}
