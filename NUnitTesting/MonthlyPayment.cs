using System;
namespace NUnitTesting
{
	public class MonthlyPayment
	{
        public static double P, Y, R, monthlyPayment, n, r;
        public static void FindMonthlyPayment()
        {
            Console.WriteLine("Enter th loan amount");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the interest");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int Y = Convert.ToInt32(Console.ReadLine());

            n = 12 * Y;
            r = R / (12 * 100);
            monthlyPayment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly Payment is:" + monthlyPayment);
        }
    }
}

