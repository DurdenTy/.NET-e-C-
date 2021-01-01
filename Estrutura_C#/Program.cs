using System;

namespace Estrutura_C_
{
    class Program
    {

        static void Declarar(){

            int a;
            int b = 4, c = 9;
            const int d = 10;
            a = 19;

            Console.WriteLine(a + b + c + d);
        }

        static void funcif(int x){

        
                Console.WriteLine(x);
            
    
        }


        static void Main(string[] args)
        {
            String nome = "Adilson";
            Console.WriteLine($"Hello World, i am {nome}");


            int n = 8, k = 0;

            Declarar();
            funcif(8);


            int[] a = new int[] {00, 11,22, 33, 44, 55, 66, 77, 88, 99, 1010};

            for(int i = 0; i < a.Length; i++){
                Console.WriteLine($"posição: {i} = " + a[i]);
            }

        }
    }
}
