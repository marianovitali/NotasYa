using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Division { get; set; } = string.Empty;
        public SchoolShift Shift { get; set; }

        public int SchoolYearId { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<TeachingAssignment> TeachingAssignments { get; set; } = new List<TeachingAssignment>();

    }
}
