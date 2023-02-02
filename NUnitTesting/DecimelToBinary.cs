using System;
namespace NUnitTesting
{
	public class DecimelToBinary
	{
		public static void FindDecimelToBinary()
		{
			Console.WriteLine("\nEnter the number");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] binaryNum = new int[32];
			int i = 0;
			while (n > 0)
			{
				binaryNum[i] = n % 2;
				n = n / 2;
				i++;
			}
			Console.WriteLine("");
			for(int j = i - 1; j >= 0; j--)
			{
				Console.Write(binaryNum[j]);
			}
		}
	}
}

