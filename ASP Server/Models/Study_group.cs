using System.ComponentModel.DataAnnotations;


namespace ASP_Server.Models
{
    public class Study_group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Group_name { get; set; }


        public Faculty? Faculty { get; set; }


        public Speciality? Speciality { get; set; }

        [Required]
        public int? Course { get; set; }

        [Required]
        [MaxLength(45)]
        public string? Education_form { get; set; }

    }
}
