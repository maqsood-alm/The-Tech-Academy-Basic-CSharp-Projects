using System;

// Class that performs math
class MathClass
{
// Method that takes two integers
public void DoMath(int firstNumber, int secondNumber)
{
int result = firstNumber * 2; // Math operation

Console.WriteLine("Result: " + result); // Show result
Console.WriteLine("Second number: " + secondNumber); // Show second number
}
}

class Program
{
static void Main(string[] args)
{
MathClass obj = new MathClass(); // Create object

obj.DoMath(5, 10); // Normal call

obj.DoMath(firstNumber: 7, secondNumber: 20); // Named parameters

Console.ReadLine(); // Pause
}
}