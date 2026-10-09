using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26.Models.UniversityEntity
{
    public class UniStudent
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Course> courses { get; set; } = new List<Course>();
    }
}
