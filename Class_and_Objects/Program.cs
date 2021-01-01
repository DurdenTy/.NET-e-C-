using System;

namespace Class_and_Objects
{
    class Program
    {

        public class Idade{

            int idade, tamanho;
            public Idade(int idade, int tamanho){
                this.idade = idade;
                this.tamanho = tamanho;
            }
        }
        static void Main(string[] args)
        {

            Idade adilson = new Idade(23, 180);

            

            Console.WriteLine("\t\tMenu interativo\n");
            Console.WriteLine("Opção 1 - Adicionar arquivo");
            Console.WriteLine("Opção 2 - Listar arquivos");
            Console.WriteLine("Opção 3 - Somar quantidade de arquivos");
            Console.WriteLine("Opção Q - Sair\n\n");

            string opcao = Console.ReadLine();

            while(opcao.ToUpper() != "Q"){

                switch(opcao){

                    case "1":
                        //Adicionar
                        break;

                    case "2":
                        //Listar
                        break;

                    case "3":
                        //Somar quantidade
                        break;

                    default:

                        throw new ArgumentOutOfRangeException("Não está entre 1 e 3, aperte Q para sair");

                }
            }



            
        }
    }
}
