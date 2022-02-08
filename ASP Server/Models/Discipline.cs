using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Discipline
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Discipline_name { get; set; }
    }
}
