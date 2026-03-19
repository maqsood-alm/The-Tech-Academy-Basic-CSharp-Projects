using System; // Allows us to use basic system functions like Console.WriteLine

// Define an interface named Quittable
// Interfaces only contain method signatures (no implementation)
interface IQuittable
{
// Define a method called Quit with no return value
void Quit();
}

// Define an Employee class
// This class implements the IQuittable interface
class Employee : IQuittable
{
// Property for Employee Name
public string Name { get; set; }

// Property for Employee ID
public int Id { get; set; }

// Implement the Quit() method from the interface
public void Quit()
{
// This is what happens when Quit() is called
Console.WriteLine($"{Name} (ID: {Id}) has quit the job.");
}
}

// Main program class
class Program
{
// Entry point of the console application
static void Main(string[] args)
{
// Create an Employee object
Employee emp = new Employee();

// Assign values to properties
emp.Name = "Maqsood Ali";
emp.Id = 101;

// Use polymorphism:
// Create an object of type IQuittable
// Even though the object is Employee, we refer to it as IQuittable
IQuittable quittableEmp = emp;

// Call the Quit() method using the interface reference
quittableEmp.Quit();

// Pause the console so output stays visible
Console.ReadLine();
}
}