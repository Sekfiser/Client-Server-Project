using System.ComponentModel.DataAnnotations;


namespace ASP_Server.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Surname { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Patronymic { get; set; }
    }
}
