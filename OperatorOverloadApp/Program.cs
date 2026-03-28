using System; // Allows use of Console methods

// Define the Employee class
class Employee
{
// Property for Employee ID
public int Id { get; set; }

// Property for First Name
public string FirstName { get; set; }

// Property for Last Name
public string LastName { get; set; }

// Overload the == operator to compare Employee objects by Id
public static bool operator ==(Employee emp1, Employee emp2)
{
// If both are the same reference, return true
if (ReferenceEquals(emp1, emp2))
return true;

// If one is null and the other is not, return false
if (emp1 is null || emp2 is null)
return false;

// Compare Id values
return emp1.Id == emp2.Id;
}

// Overload the != operator (must be done with ==)
public static bool operator !=(Employee emp1, Employee emp2)
{
// Return the opposite of ==
return !(emp1 == emp2);
}

// Override Equals method
public override bool Equals(object obj)
{
if (obj is Employee emp)
{
return this.Id == emp.Id;
}
return false;
}

// Override GetHashCode method
public override int GetHashCode()
{
return Id.GetHashCode();
}
}

// Main program class
class Program
{
static void Main(string[] args)
{
// Create first Employee object
Employee emp1 = new Employee
{
Id = 1,
FirstName = "Maqsood",
LastName = "Ali"
};

// Create second Employee object
Employee emp2 = new Employee
{
Id = 1, // Same ID to test equality
FirstName = "Victor",
LastName = "Wong"
};

// Compare employees using overloaded ==
Console.WriteLine("Are employees equal? " + (emp1 == emp2));

// Compare employees using overloaded !=
Console.WriteLine("Are employees NOT equal? " + (emp1 != emp2));

// Pause console
Console.ReadLine();
}
}