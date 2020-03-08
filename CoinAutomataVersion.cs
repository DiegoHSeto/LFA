using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinAutomataVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, string>> states = new Dictionary<string, Dictionary<int, string>>()
            {
                { "q1" , new Dictionary<int, string>() { { 25, "q2"},
                                                         { 10, "q4"} }
                },
                { "q2" , new Dictionary<int, string>() { { 10, "q3"},
                                                         { 25, "q8"} }
                },
                { "q3" , new Dictionary<int, string>() { { 25, "q8"},
                                                         { 10, "q8"} }
                },
                { "q4" , new Dictionary<int, string>() { { 25, "q3"},
                                                         { 10, "q5"} }
                },
                { "q5" , new Dictionary<int, string>() { { 25, "q8"},
                                                         { 10, "q6"} }
                },
                { "q6" , new Dictionary<int, string>() { { 25, "q8"},
                                                         { 10, "q7"} }
                },
                { "q7" , new Dictionary<int, string>() { { 25, "q8"},
                                                         { 10, "q8"} }
                }
            };

            int[] validCoins = new int[] { 10, 25 };

            string initialState = "q1";

            string finalState = "q8";

            string currentState = initialState;


            Console.WriteLine("Produto selecionado: Coca-Cola. Valor: 45 centavos\n");

            while(currentState != finalState)
            {
                Console.WriteLine("Insira sua moeda!");

                int coin = Convert.ToInt32(Console.ReadLine());

                if(!validCoins.Contains(coin))
                {
                    Console.WriteLine("Moeda não reconhecida!");

                    continue;
                }

                currentState = states[currentState][coin];
            }

            Console.WriteLine("Aproveite seu refrigerante!");


        }
    }
}
