using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASP_Server.Models;

namespace ASP_Server.Data
{
    public partial class TimetabledbContext : DbContext
    {
        public TimetabledbContext(DbContextOptions<TimetabledbContext> options) : base(options)
        {
        }

        public DbSet<Classroom>? Classrooms { get; set; }
        public DbSet<Discipline>? Disciplines { get; set; }
        public DbSet<Lesson_time>? Lesson_times { get; set; }
        public DbSet<Lesson_type>? Lesson_types { get; set; }
        public DbSet<Professor>? Professors { get; set; }
        public DbSet<Study_group>? Study_groups { get; set; }
        public DbSet<Timetable>? Timetables { get; set; }
        public DbSet<Week_day>? Week_days { get; set; }
        public DbSet<Week_parity>? Week_parities { get; set; }
        public DbSet<Faculty>? Faculties { get; set; }
        public DbSet<Speciality>? Specialities { get; set; }
    }
}
