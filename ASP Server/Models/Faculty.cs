using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Faculty_name { get; set; }
    }
}
