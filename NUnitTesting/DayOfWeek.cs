using System;
namespace NUnitTesting
{
	public class DayOfWeek
	{
        public static void FindDayOfWeek()
        {
            int Y, x, M,D;
            Console.WriteLine("Enter Date, Month & Year");
            int d = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            Y = y - (14 - m) / 12;
            x = Y + Y / 4 - Y / 100 + Y / 400;
            M = m + 12 * ((14 - m) / 12) - 2;
            D = (d + x + (31*M) / 12) % 7;
            switch (D)
            {
                case 1:
                    Console.WriteLine("The Day is:{0} ==> Monday",D);
                    break;
                case 2:
                    Console.WriteLine("The Day is:{0} ==> Tuesday", D);
                    break;
                case 3:
                    Console.WriteLine("The Day is:{0} ==> Wednesday", D);
                    break;
                case 4:
                    Console.WriteLine("The Day is:{0} ==> Thursday", D);
                    break;
                case 5:
                    Console.WriteLine("The Day is:{0} ==> Friday", D);
                    break;
                case 6:
                    Console.WriteLine("The Day is:{0} ==> Saturday", D);
                    break;
                default:
                    Console.WriteLine("The Day is:{0} ==> Sunday", D);
                    break;
            }
            //Console.WriteLine("The Day is: " + D);
        }
    }
}

