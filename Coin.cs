using System;
using System.Linq;

class MainClass 
{
  public static void Main (string[] args) 
  {         
    double total = 0;

    double price = 0.45;

    double [] validCoins = new double [] {0.10, 0.25};
    
    while(total <= price)
    {
        double myCoin;

        Console.WriteLine("Insira sua moeda:");

        myCoin = Convert.ToDouble(Console.ReadLine());

        if(!validCoins.ToList().Contains(myCoin))
        {
          Console.WriteLine("Tipo de moeda não reconhecido!");

          continue;
        }

        total += myCoin;

        if(total >= price)
        {
          Console.WriteLine("Aproveite sua Coca-Cola :)");
          break;
        }

    }
  }
}
