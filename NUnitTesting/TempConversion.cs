using System;
namespace NUnitTesting
{
	public class TempConversion
	{
		public static void FindTempConversion()
		{
			double f,c;
			Console.WriteLine("Welcome to temparature conversion");
			Console.WriteLine("\n1:Celsius\n2:Fahrenheit");
			int option = Convert.ToInt32(Console.ReadLine());
			switch (option)
			{
				case 1:
					Console.WriteLine("\nEnter the Temperature to find Celsius to Fahrenheit");
					c = Convert.ToInt32(Console.ReadLine());
					f = (c * 9 / 5) + 32;
					Console.WriteLine("\nTemperature Celsius to Farenheit: {0} °F",f);
					break;
				case 2:
					Console.WriteLine("\nEnter the Temperature to find Fahrenheit to Celsius");
					f = Convert.ToInt32(Console.ReadLine());
					c = (f - 32) * 5 / 9;
                    			Console.WriteLine("\nTemperature Farenheit to Celsius: {0} °C",c);
                    			break;
			}
		}
	}
}

