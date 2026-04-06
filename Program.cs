using System;
using StudentApp.Data;
using StudentApp.Models;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create database if it doesn't exist
                context.Database.EnsureCreated();

                // Add a student
                var student = new Student { Name = "Maqsood Ali", Age = 36 };
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }
        }
    }
}