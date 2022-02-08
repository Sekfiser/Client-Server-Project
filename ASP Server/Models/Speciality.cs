using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Speciality_name { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Abbreviated_speciality { get; set; }
    }
}
