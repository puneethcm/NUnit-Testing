using System;
namespace NUnitTesting
{
	public class SqrtNewton
	{
		public static void FindSqrtNewton()
		{
			Console.WriteLine("\nEnter the number");
			double c = Convert.ToInt32(Console.ReadLine());
			double l = 0.000000000000001;
			double t = c;
			double root;
			int count = 0;

			while (true)
			{
				count++;
				root = 0.5 * (t + (c / t));
				if (Math.Abs(t-(c / t)) < (l * t))
				{
					break;
				}
				t = root;
			}
			Console.WriteLine("\nThe Square Root {0} is : {1}",c,t);
		}
	}
}

