using NUnitTesting;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to NUnit Testing Program");
        Console.WriteLine("\n1:Vending Machine\n2:Temperatute Conversion");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Vending.GetVending();
                break;
            case 2:
                TempConversion.FindTempConversion();
                break;
        }
        Console.ReadLine();
    }
}