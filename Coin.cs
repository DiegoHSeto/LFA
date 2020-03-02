using System;
using System.Linq;

class MainClass 
{
  public static void Main (string[] args) 
  {         
    int total = 0;

    int price = 45;

    int [] validCoins = new int [] {10, 25};
    
    while(total <= price)
    {
        int myCoin;

        Console.WriteLine($"Insira sua moeda abaixo. Moedas válidas: {string.Join(',', validCoins)}");

        myCoin = Convert.ToInt32(Console.ReadLine());

        if(!validCoins.ToList().Contains(myCoin))
        {
          Console.WriteLine("Tipo de moeda não reconhecido!");

          continue;
        }

        total += myCoin;

        Console.WriteLine($"\nTotal: {total}\n");

        if(total >= price)
        {
          Console.WriteLine("Aproveite sua Coca-Cola :)");

          if((total - price) != 0)
          {
            Console.WriteLine($"Perdeu {(total - price)} centavos");
          }

          break;
        }
    }
  }
}
