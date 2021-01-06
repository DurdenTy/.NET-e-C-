using System;

namespace Somar_Média_entre_5_variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            double item, item2, item3, item4, item5, media;

            Console.WriteLine("Calcular a média entre 5 variáveis\n\n");

            Console.WriteLine("Coloque o var 1: ");
            item = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque o var 2: ");
            item2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque o var 3: ");
            item3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque o var 4: ");
            item4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque o var 5: ");
            item5 = Convert.ToDouble(Console.ReadLine());

            media = (item + item2 + item3 + item4 + item5)/5;

            Console.WriteLine("A média é igual a:" + media);

            Console.ReadKey();


        }
    }
}
