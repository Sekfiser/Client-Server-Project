using System.ComponentModel.DataAnnotations;

namespace ASP_Server.Models
{
    public class Timetable
    {
        [Key]
        public int Id { get; set; }

        public Lesson_time? Lesson_time { get; set; }

        public Week_parity? Week_parity { get; set; }

        public Week_day? Week_day { get; set; }

        public Classroom? Classroom { get; set; }

        public Study_group? Study_group { get; set; }

        public Professor? Professor { get; set; }

        public Discipline? Discipline { get; set; }

        public Lesson_type? Lesson_type { get; set; }
    }
}
