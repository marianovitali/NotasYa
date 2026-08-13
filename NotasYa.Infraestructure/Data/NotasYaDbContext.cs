using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotasYa.Domain.Entities;
using NotasYa.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Infrastructure.Data
{
    public class NotasYaDbContext : IdentityDbContext<ApplicationUser>
    {
        public NotasYaDbContext(DbContextOptions<NotasYaDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<SchoolYear> SchoolYears => Set<SchoolYear>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<TeachingAssignment> TeachingAssignments => Set<TeachingAssignment>();
        public DbSet<Grade> Grades => Set<Grade>();
        public DbSet<Attendance> Attendances => Set<Attendance>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Student → Course
            builder.Entity<Student>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Course → SchoolYear
            builder.Entity<Course>()
                .HasOne(c => c.SchoolYear)
                .WithMany()      
                .HasForeignKey(c => c.SchoolYearId)   
                .OnDelete(DeleteBehavior.Restrict);     

            // TeachingAssignment → Course
            builder.Entity<TeachingAssignment>()
                .HasOne(t => t.Course)
                .WithMany(c => c.TeachingAssignments)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // TeachingAssignment → Subject
            builder.Entity<TeachingAssignment>()
                .HasOne(t => t.Subject)
                .WithMany(s => s.TeachingAssignments)
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // Grade → Student
            builder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Grade → TeachingAssignment
            builder.Entity<Grade>()
                .HasOne(g => g.TeachingAssignment)
                .WithMany(t => t.Grades)
                .HasForeignKey(g => g.TeachingAssignmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Grade → SchoolYear
            builder.Entity<Grade>()
                .HasOne(g => g.SchoolYear)
                .WithMany()
                .HasForeignKey(g => g.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attendance → Student
            builder.Entity<Attendance>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attendance → SchoolYear
            builder.Entity<Attendance>()
                .HasOne(a => a.SchoolYear)
                .WithMany()
                .HasForeignKey(a => a.SchoolYearId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student
            builder.Entity<Student>()
                .HasIndex(s => s.Dni)
                .IsUnique();

            builder.Entity<Student>()
                .Property(s => s.Dni)
                .HasMaxLength(20)
                .IsRequired();

            // Subject
            builder.Entity<Subject>()
                .Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            // Course
            builder.Entity<Course>()
                .Property(c => c.Division)
                .HasMaxLength(10)
                .IsRequired();

            // ApplicationUser
            builder.Entity<ApplicationUser>()
                .Property(u => u.Dni)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .HasIndex(u => u.Dni)
                .IsUnique();
        }
    }
}
