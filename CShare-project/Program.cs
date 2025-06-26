using System;
class Program
{
  static void SystemConSoleClass()
  {
	// SystemConSoleClass example
/* 	Console.Write("Enter your name:");
	string name = Console.ReadLine();
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.WriteLine($"Hello, {name}!");
	Console.ResetColor(); */
	
	// Static Methods
	/* int result = Square(4);
	Console.WriteLine(result); */
	
	// Default Arguments
	/* Greet();
	Greet("Vaibhav"); */
	
	//Named Arguments
	/* PrintDetails(age:27, name: "vaibhav"); */
	
	//ref
	int x = 5;
	AddTen(ref x);
	
	//Params
	Sum(1,2,3);
	
	//Out Parameter
	int quotient, rem;
	Divide(10, 3, out quotient, out rem);
	Console.WriteLine($"Quotient: {quotient}, Remainder: {rem}");
	
	//Ref out parameter
	int number = 10;
	int result;
	
	RefOut(ref number, out result);
	
	Console.WriteLine($"Modified Number (ref): {number}");   // Output: 15
    Console.WriteLine($"Square (out): {result}");  
  }	  
  
  public static void Main()
  { 
    SystemConSoleClass();
  }
  
  public static int Square(int x)
  {
	return x*x;
  }
  
  static void Greet(string name = "Guest")
  {
	Console.WriteLine($"Hello, {name}");
  }
  
  static void PrintDetails(string name, int age)
  {
	Console.WriteLine($"{name} - {age}");
  }
  
  public static void AddTen(ref int number)
  {
	  number += 10;
	  Console.WriteLine(number);
  }
  
  public static void Sum(params int[] numbers)
  {
	  int total = 0;
	  foreach (var n in numbers) total += n;
	  Console.WriteLine(total);
  }
  
  static void Divide(int a, int b, out int result, out int remainder)
  {
	  result = a / b;
	  remainder = a % b;
  }
  
  static void RefOut(ref int value, out int square)
  {
	  value += 5;
	  square = value * value;
  }
}