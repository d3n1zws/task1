using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26.Models.UniversityEntity
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UniStudent> uniStudents { get; set; } = new List<UniStudent>();
    }
}
