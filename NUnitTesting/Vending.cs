using System;
namespace NUnitTesting
{
	public class Vending
	{
		public static void GetVending()
		{
            		Console.WriteLine("Enter the Amount");
            		int amount = Convert.ToInt32(Console.ReadLine());
			int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
			int[] noteCounter = new int[10];

            		for (int i = 0; i < 10; i++)
            		{
                		if (amount >=  notes[i])
                		{
                    			noteCounter[i] = amount / notes[i];
                    			amount = amount % notes[i];
                		}
            		}
            				Console.WriteLine("Currency amount ->");
            		for(int i = 0; i < 10; i++)
            		{
                		if (noteCounter[i] != 0)
                		{
                    			Console.WriteLine(notes[i] +" : "+ noteCounter[i]);
                		}
            		}
		}
	}
}
