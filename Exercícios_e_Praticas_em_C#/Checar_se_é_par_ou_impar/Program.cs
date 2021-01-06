using System;

namespace Checar_se_é_par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Saber se o seu número é par ou impar\n\n");
            Console.WriteLine("Coloque o seu número");
            num = Convert.ToInt32(Console.ReadLine());

            if(num == 0){
                Console.WriteLine("Seu número é neutro");
            }
            else if(num % 2 == 0){
                Console.WriteLine("Seu número é par");
            }else{
                Console.WriteLine("Seu número não é par");
            }
        }
    }
}
