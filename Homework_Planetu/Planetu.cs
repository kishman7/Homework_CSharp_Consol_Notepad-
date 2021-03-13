using System;
using System.Globalization; //простір імен, щоб можна було дробне число прописувати з "."(23.21)

namespace Classwork
{
	enum Planeta
{
	Merkyriy=1,	Venera=2, Zemlya=3,	Mars=4,	Yupiter=5,
	Saturn=6, Uran=7, Neptun=8,	Pluton=9,
}
class Program
{
static void Main(string[] args)
{
Console.OutputEncoding = System.Text.Encoding.UTF8; //підключення українських букв
Planeta planeta; //оголошується обєкт enum класу
//planeta=Planeta.Merkyriy; // присвоюємо змінній planeta значення з переліку enum
//Console.WriteLine(planeta); // виводимо значення "Merkyriy"
//Console.WriteLine((int)planeta); // приводимо до типу int, виведе "1"
//Console.WriteLine((Planeta)3); // виведе значення "Zemlya"
Enum.IsDefined(typeof(Planeta),5);
bool action = true;
while(action)
{
	Console.WriteLine("Виберіть планету за її номером по віддаленості від сонця (від 1 до 9).");
	Console.WriteLine("Якщо бажаєте завершити, то натисніть \"0\".");
	int enter = Convert.ToInt32(Console.ReadLine());
	switch (enter)
	{
		case 1:
		{
			Console.WriteLine("Меркурій " + ((int)(Planeta)1) + " найближча планета до сонця, а також найменша планета сонячної системи.");
			Console.WriteLine();
			break;
		}
		case 2:
		{
			Console.WriteLine("Венера " + ((int)(Planeta)2) + " планета від сонця, планета, яка є найгарячійша.");
			Console.WriteLine();
			break;
		}
		case 3:
		{
			Console.WriteLine("Земля " + ((int)(Planeta)3) + " планета від сонця, єдина планета, на якій присутня можливість життя живих організмів.");
			Console.WriteLine();
			break;
		}
		case 4:
		{
			Console.WriteLine("Марс " + ((int)(Planeta)4) + " планета від сонця, планета, яка має червоний колір та на ній знаходяться марсоходи.");
			Console.WriteLine();
			break;
		}
		case 5:
		{
			Console.WriteLine("Юпітер " + ((int)(Planeta)5) + " планета від сонця, планета, яка є газоподібна.");
			Console.WriteLine();
			break;
		}
		case 6:
		{
			Console.WriteLine("Сатурн " + ((int)(Planeta)6) + " планета від сонця, планета, яка має великі кільця навколо себе, які створені з \"космічного сміття\".");
			Console.WriteLine();
			break;
		}
		case 7:
		{
			Console.WriteLine("Уран " + ((int)(Planeta)7) + " планета від сонця, планета, яку називають \"Крижаним гігантом\".");
			Console.WriteLine();
			break;
		}
		case 8:
		{
			Console.WriteLine("Нептун " + ((int)(Planeta)8) + " планета від сонця, планета названа на честь римського бога морів.");
			Console.WriteLine();
			break;
		}
		case 9:
		{
			Console.WriteLine("Плутон " + ((int)(Planeta)9) + " планета від сонця, планета не відповідає формальному терміну \"планета\", тому була виключена зі списку планет.");
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
			Console.WriteLine("Невірно обраний номер планети. Спробйте ще раз !!!");
			Console.WriteLine();
			break;
		}
	}
}
}
}
}