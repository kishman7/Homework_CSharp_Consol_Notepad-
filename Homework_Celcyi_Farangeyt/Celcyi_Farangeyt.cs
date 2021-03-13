using System;
using System.Globalization; //простір імен, щоб можна було дробне число прописувати з "."(23.21)
namespace Classwork
{
class Program
{
static void Main(string[] args)
{
double TC, TF;
NumberFormatInfo numberFormatInfo = new NumberFormatInfo() //створюємо обєкт класа, щоб можна було дробне число прописувати з "."(23.21)
{
	NumberDecimalSeparator = ".",
};
Console.WriteLine("Enter the temperature in Celsius: ");
TC = Convert.ToDouble(Console.ReadLine(), numberFormatInfo); // додаємо обєкт класа в метод Convert
TF = TC *1.8 +32;

Console.WriteLine("Temperature in Fahrenheit = " + TF);

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