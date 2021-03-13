using System;
using System.Globalization; //простір імен, щоб можна було дробне число прописувати з "."(23.21)
namespace Classwork
{
class Program
{
static void Main(string[] args)
{
//Regex regex = new Regex("^[А-Яа-яёЁЇїІіЄєҐґ]+$");
double Sm, Duim;
NumberFormatInfo numberFormatInfo = new NumberFormatInfo() //створюємо обєкт класа, щоб можна було дробне число прописувати з "."(23.21)
{
	NumberDecimalSeparator = ".",
};
Console.WriteLine("Enter centimeters: ");
Sm = Convert.ToDouble(Console.ReadLine(), numberFormatInfo); // додаємо обєкт класа в метод Convert
Duim = Sm /2.54;

Console.WriteLine(Sm + " centimeters = " + Math.Round(Duim, 2) + " duim");

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