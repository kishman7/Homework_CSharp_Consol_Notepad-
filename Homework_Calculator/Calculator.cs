using System;
using System.Globalization; //простір імен, щоб можна було дробне число прописувати з "."(23.21)
namespace Classwork
{
class Program
{
static void Main(string[] args)
{
Console.OutputEncoding = System.Text.Encoding.UTF8; //підключення українських букв
NumberFormatInfo numberFormatInfo = new NumberFormatInfo() //створюємо обєкт класа, щоб можна було дробне число прописувати з "."(23.21)
{
	NumberDecimalSeparator = ".",
};
double a, b;
double result = 0;
Console.WriteLine("CALCULATOR");
Console.WriteLine("Enter number 1: ");
a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo); // додаємо обєкт класа в метод Convert
Console.WriteLine("Enter number 2: ");
b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo); // додаємо обєкт класа в метод Convert
bool action = true;
while(action)
{
	Console.WriteLine("CALCULATOR");
	Console.WriteLine("1.Addition.");
	Console.WriteLine("2.Subtraction.");
	Console.WriteLine("3.Multiplication.");
	Console.WriteLine("4.Division.");
	Console.WriteLine("0.Exit.");
	Console.WriteLine("Select a menu item: ");
	int enter = Convert.ToInt32(Console.ReadLine());
	switch (enter)
	{
		case 1:
		{
			Console.WriteLine();
			result = a + b;
			Console.WriteLine(a + " + " + b + " = " + result);
			Console.WriteLine();
			break;
		}
		case 2:
		{
			Console.WriteLine();
			result = a - b;
			Console.WriteLine(a + " - " + b + " = " + result);
			Console.WriteLine();
			break;
		}
		case 3:
		{
			Console.WriteLine();
			result = a * b;
			Console.WriteLine(a + " * " + b + " = " + result);
			Console.WriteLine();
			break;
		}
		case 4:
		{
			Console.WriteLine();
			result = a / b;
			if(b!=0)
			{
				Console.WriteLine(a + " / " + b + " = " + result);
			}
			else
			{
				Console.WriteLine("You can't divide by 0 !!!");
				Console.WriteLine();
				break;
			}
			Console.WriteLine();
			break;
		}
		case 0:
		{
			action = false;
			break;
		}
		default:
		{
			Console.WriteLine("The menu item entered is incorrect !!!");
			Console.WriteLine();
			break;
		}
	}
}



Console.ReadLine();
//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("How old are you?");
//int age = 29;
//Console.WriteLine("Hello, {​​​​0}​​​​! I'am {​​​​1}​​​​ ", name, age);
//Console.ReadLine();
}
}
}