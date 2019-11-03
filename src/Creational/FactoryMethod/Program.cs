using System;

namespace FactoryMethod
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What smartphone do you want to use?");

      Console.WriteLine("Available options:");
      Console.WriteLine("1 - Apple phone");
      Console.WriteLine("2 - Samsung phone");
      Console.WriteLine("3 - Xiaomi phone");

      Console.Write("Your choice: ");

      if (Enum.TryParse(Console.ReadLine(), out CompanyName companyType))
      {
        SmartphoneCreator smartphoneCreator = companyType switch
        {
          CompanyName.Apple => new AppleSmartphoneCreator(),
          CompanyName.Samsung => new SamsungSmartphoneCreator(),
          CompanyName.Xiaomi => new XiaomiSmartphoneCreator(),
          _ => throw new ArgumentException("Sorry, we don't support such kind of smartphone")
        };

        Console.Write("Enter a mobile phone: ");

        smartphoneCreator
          .Create()
          .Call(Console.ReadLine());
      }
      else
      {
        Console.WriteLine("Invalid choice. Please try later again.");
      }
    }
  }
}
