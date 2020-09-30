/*La un spectacol artistic biletul de intrare pentru copiii sub vârsta de 14 ani are 50% reducere.
Să se scrie o aplicație consolă ce primește ca date de intrare prețul întreg al biletului și vârsta unei persoane și 
afișează prețul pe care persoana respectivă trebuie să-l plătească pentru un bilet la spectacol.
Exemplu:
Pentru datele de intrare:
60
9
La consolă se va afișa:
30*/

using System;

namespace Test1Pb2Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double listPrice = (double)Convert.ToDouble(inputData);

            inputData = Console.ReadLine();
            double age = (double)Convert.ToDouble(inputData);

            double halfOffPrice = (listPrice * 50) / 100;

            double finalPrice = (age < 14) ? halfOffPrice : listPrice;

            Console.WriteLine(finalPrice);
            Console.Read();
            }
        }
    }
