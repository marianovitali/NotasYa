using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    public class TeachingAssignment
    {
        public int Id { get; set; }

        public string TeacherId { get; set; } = string.Empty;

        public int CourseId { get; set; }

        public int SubjectId { get; set; }

        public Course Course { get; set; } = null!;

        public Subject Subject { get; set; } = null!;

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
