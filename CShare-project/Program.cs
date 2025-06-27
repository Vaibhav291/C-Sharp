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
	/* int x = 5;
	AddTen(ref x);
	 */
	//Params
	/* Sum(1,2,3); */
	
	//Out Parameter
	/* int quotient, rem;
	Divide(10, 3, out quotient, out rem);
	Console.WriteLine($"Quotient: {quotient}, Remainder: {rem}"); */
	
	//Ref out parameter
	/* int number = 10;
	int result;
	
	RefOut(ref number, out result);
	
	Console.WriteLine($"Modified Number (ref): {number}");   // Output: 15
    Console.WriteLine($"Square (out): {result}");  */

    //Implicit Casting
    /* int a =10;
    double b = a;
    Console.WriteLine(b);	 */
	
	//Explicit Casting
/* 	double x = 9.8;
	int y = (int)x;
	Console.WriteLine(y); */
	
	//Parse
/* 	string numberStr = "123";
	int num = int.Parse(numberStr);
	Console.WriteLine(num);
	
	int bad = int.Parse("abc"); // throws FormatException */
	
	//TryParse
/* 	string input = "456";
	if(int.TryParse(input, out int result))
	{
		Console.WriteLine(result);
	}else{
		Console.WriteLine("Invalid Number");
	}	 */
	
	//Conversion Methods
/* 	string str = "789";
	int num = Convert.ToInt32(str);
	Console.WriteLine(num);
	
	string nullstr = null;
	int val = Convert.ToInt32(nullstr);
	Console.WriteLine(val); */
	
	//Instance Constructor Usage
/* 	var p = new Person("Vaibhav");
	Console.WriteLine(p.Name); */
	
	//Constructor Overloading
/* 	var e1 = new ConstructorOverloading();
	var e2 = new ConstructorOverloading("vaibhav");
	var e3 = new ConstructorOverloading("vaibhav", 27);
	Console.WriteLine(e1);
	Console.WriteLine(e2);
	Console.WriteLine(e3); */
	
	//Object Initializer
/* 	var s = new Student { Name = "Vaibhav", Age = 27 };
	Console.WriteLine($"{s.Name}, {s.Age}"); */
  }	  
  
/*   static string logFile;
  
  static Program()
    {
        logFile = "app.log";
        Console.WriteLine("Static constructor called");
    }
   */
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

/* class Person
{
	public string Name;
	
	//Instance constructor
	public Person(string name)
	{
		Name = name;
	}
} */

//Default Constructor
/* class Car
{
    public string Model;
}
var c = new Car(); // Default constructor
 */
 
 //Parameterzied Constructor
/*  class Car
{
    public string Model;
    public Car(string model)
    {
        Model = model;
    }
} */

//Copy Constructor
/* class Car
{
    public string Model;
    public Car(Car other)
    {
        Model = other.Model;
    }
}
 */
 
 //Constructor Overloading
 /* class ConstructorOverloading{
	 
	public string Name;
	public int Age;
	
	public ConstructorOverloading(){
		Name = "unknown";
		Age = 0;
	}
	
	public ConstructorOverloading(string name){
		Name = name;
		Age = 0;
	}
	
	public ConstructorOverloading(string name, int age){
		Name = name;
		Age = age;
	}
 } */

/* class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
} */