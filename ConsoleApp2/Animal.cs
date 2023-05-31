using System;
namespace ConsoleApp2
{
	class Animal
	{
		public string Name { get; set; }
		public Animal(string name="no name")
		{
			Name = name;
		}

		public static void GetSum<T>(ref T num1, ref T num2)
		{
			double dbLX = Convert.ToDouble(num1);
			double dbLX2 = Convert.ToDouble(num2);

			Console.WriteLine($"{dbLX}+ {dbLX2} = {dbLX + dbLX2}");
		}
	}
}

