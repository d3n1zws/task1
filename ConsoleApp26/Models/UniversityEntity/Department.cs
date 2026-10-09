using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26.Models.UniversityEntity
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students { get; set; }
    }
}
