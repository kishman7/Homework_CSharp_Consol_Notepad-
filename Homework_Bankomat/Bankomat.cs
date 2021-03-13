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
int password; // створений пароль
Console.WriteLine("Create your password: ");
password = int.Parse(Console.ReadLine());
double deposit;
Console.WriteLine("Enter your start deposit: ");
deposit = double.Parse(Console.ReadLine(), numberFormatInfo);
Console.Clear(); // очистка екрана
Console.WriteLine("===BANKOMAT===");
int N = 3; //кількість спроб
bool flag = false; // булівська змінна для підтвердження введеного пароля
int enter_password; // введений пароль для підтвердження
Console.WriteLine("Log in. You have " + N + " attempts!!!");

for	(int i = 0; i < N; i++)
{
	Console.WriteLine("Enter your password: ");
	enter_password = int.Parse(Console.ReadLine());
	if(password == enter_password)
	{
		flag = true;
		Console.WriteLine("You are successfully logged in!!!");
		Console.WriteLine();
		bool action = true;
		while(action)
		{
			Console.WriteLine("=MENU=");
			Console.WriteLine("1.Сurrent account balance.");
			Console.WriteLine("2.Withdraw money.");
			Console.WriteLine("0.Exit.");
			Console.WriteLine("Select a menu item: ");
			int enter = int.Parse(Console.ReadLine());
			switch (enter)
			{
				case 1:
				{
					Console.WriteLine("Account balance: " + deposit + " usd");
					Console.WriteLine();
					break;
				}
				case 2:
				{
					Console.WriteLine("Your account balance: " + deposit + " usd");
					Console.WriteLine("How much do you want to withdraw? ");
					double withdraw = double.Parse(Console.ReadLine(), numberFormatInfo);
					if(withdraw < deposit)
					{
						deposit -= withdraw;
						Console.WriteLine("You have successfully withdrawn the amount: " + withdraw + " usd");
					}
					else
					{
						Console.WriteLine("Not enough money !!!");
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
		break;
	}
	else
	{
		Console.WriteLine("The password was entered incorrectly. Please try again!");
	}
}
if(flag == false)
{
	Console.WriteLine("Sorry, but you used your " + N + " attempts!");
}

Console.ReadLine();

}
}
}