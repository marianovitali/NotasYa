using NotasYa.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int TeachingAssignmentId { get; set; }

        public int SchoolYearId { get; set; }

        public Term? Term { get; set; }

        public GradeType GradeType { get; set; }

        public decimal? NumericValue { get; set; }

        public QualitativeGrade? QualitativeValue { get; set; }

        public string? Comments { get; set; }

        public DateTime CreatedAt { get; set; }

        public Student Student { get; set; } = null!;

        public TeachingAssignment TeachingAssignment { get; set; } = null!;

        public SchoolYear SchoolYear { get; set; } = null!;
    }
}
