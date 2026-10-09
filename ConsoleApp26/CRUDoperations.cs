using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp26.Models;
using ConsoleApp26.DAL;
namespace ConsoleApp26
{
    public static class CRUDoperations
    {
        public static async Task CreateStudent(string firstName, string lastName, string email, int age)
        {
            var context = new SchoolDbContext();
            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Age = age
            };
            context.Students.Add(student);
            await context.SaveChangesAsync();
            Console.WriteLine("Student created successfully.");
        }
        public static void ReadStudents()
        {
            var context = new SchoolDbContext();
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.FirstName} {student.LastName}, Email: {student.Email}, Age: {student.Age}");
            }
        }
        public static async Task UpdateStudent(int id, string firstName, string lastName, string email, int age)
        {
            var context = new SchoolDbContext();
            var student = context.Students.Find(id);
            if (student != null)
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Email = email;
                student.Age = age;
                await context.SaveChangesAsync();
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                throw new Exception("Student not found.");
            }
        }
        public static async Task DeleteStudent(int id)
        {
            var context = new SchoolDbContext();
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                await context.SaveChangesAsync();
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                throw new Exception("Student not found.");
            }
        }
    }
}
