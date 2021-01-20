using System;

namespace simplecode3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертер валюты");
            
            double numberDollar = 73.46;            double numberEuro = 88.97;
            double yourKonvert;

            Console.WriteLine("Какая у тебя валюта?(Напиши Доллар или Евро)");        string yourChange = Console.ReadLine();

            Console.WriteLine("Какая сумма?");                                        double yourMoney = Convert.ToDouble(Console.ReadLine());


            if (yourChange == "Доллар")
            {
                yourKonvert = yourMoney * numberDollar;
                Console.WriteLine($"Вот столько у тебя рублей {yourKonvert}");
            }
            else if (yourChange == "Евро") 
            {
                yourKonvert = yourMoney * numberEuro;
                Console.WriteLine($"Вот столько у тебя рублей {yourKonvert}");
            }
            else
            {
                Console.WriteLine("Такой валюты нет");
            }
        }
    }
}
