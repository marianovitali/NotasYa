using NotasYa.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string Dni { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        public StudentStatus Status { get; set; } = StudentStatus.Active;

        public int CourseId { get; set; }

        public Course Course { get; set; } = null!;

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
