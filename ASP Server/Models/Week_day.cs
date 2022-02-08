using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Week_day
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string? Day { get; set; }
    }
}
