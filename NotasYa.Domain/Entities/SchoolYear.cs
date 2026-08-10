using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Domain.Entities
{
    public class SchoolYear
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
    }
}
