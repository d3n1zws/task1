using ConsoleApp26.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26.Services
{
    public static class StudentService
    {
        public static void FindStudentsByAge(int age)
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().Where(x => x.Age >= age);
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static void OrderStudentsByName() 
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().OrderBy(s => s.FirstName);
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static void FindTop3OldestStudents()
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().OrderByDescending(s => s.Age).Take(3);
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static void FindStudentByName(string name)
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().Where(s => s.FirstName.ToLower() == name.ToLower() || s.LastName.ToLower() == name.ToLower());
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static void FindCountOfStudents()
        {
            var context = new SchoolDbContext();
            var count = context.Students.Count();
            Console.WriteLine($"Total number of students: {count}");
        }
        public static void FindStudentsByAge(int minage, int maxage)
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().Where(x => x.Age >= minage && x.Age <= maxage);
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static void FindStudentsByEmailDomain(string domain)
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList().Where(x => x.Email.EndsWith(domain));
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
    }
}
