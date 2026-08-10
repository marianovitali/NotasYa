using Microsoft.AspNetCore.Identity;
using NotasYa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Infraestructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Dni { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
        public ICollection<TeachingAssignment> TeachingAssignments { get; set; } = new List<TeachingAssignment>();

    }
}
