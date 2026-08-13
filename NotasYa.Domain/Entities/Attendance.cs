using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SchoolYearId { get; set; }

        public int Absences { get; set; }

        public Student Student { get; set; } = null!;

        public SchoolYear SchoolYear { get; set; } = null!;
    }
}
