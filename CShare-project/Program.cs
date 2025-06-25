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
}