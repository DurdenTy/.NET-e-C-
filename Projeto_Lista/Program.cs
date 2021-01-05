using System;

namespace Projeto_Lista
{
    class Program
    {

        public struct Arquivos{
            
            public string Nome { set; get;}
            public decimal Numero {set; get;}

        }
        static void Main(string[] args)
        {
            
            Arquivos[] arquivados = new Arquivos[5];
            int IndiceArquivo = 0;


            Console.WriteLine("\t\tMenu interativo\n");
            Console.WriteLine("Opção 1 - Adicionar arquivo");
            Console.WriteLine("Opção 2 - Listar arquivos");
            Console.WriteLine("Opção 3 - Quantidade de arquivos");
            Console.WriteLine("Opção Q - Sair\n\n");

            string opcao = Console.ReadLine();

            while(opcao.ToUpper() != "Q"){

                switch(opcao){

                    case "1":
                        //Adicionar
                        Console.WriteLine("Informe o nome do Arquivo");
                        var arquivado = new Arquivos();
                        arquivado.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o número do arquivo");

                        if (decimal.TryParse(Console.ReadLine(), out decimal N))
                        {
                            arquivado.Numero = N;
                        }
                        else
                        {
                            throw new ArgumentNullException("Número fora de contexto");
                        }

                        arquivados[IndiceArquivo] = arquivado;
                        IndiceArquivo++;

                        break;

                    case "2":
                        //Listar
                        foreach(var a in arquivados){
                            if(!a.Nome.Equals("")){
                                Console.WriteLine("Arquivo:" + a.Nome + "\nNúmero do arquivo:" + a.Numero);
                            }
                        }
                        break;

                    case "3":
                        //Quantidade      
                        Console.WriteLine("O quantidade total é "+ IndiceArquivo + "\n\n");
                        break;


                    default:

                        throw new ArgumentOutOfRangeException("Não está entre 1 e 3, o programa irá ser fechado");

                }

                Console.WriteLine("\t\tMenu interativo\n");
                Console.WriteLine("Opção 1 - Adicionar arquivo");
                Console.WriteLine("Opção 2 - Listar arquivos");
                Console.WriteLine("Opção 3 - Quantidade de arquivos");
                Console.WriteLine("Opção Q - Sair\n\n");

                opcao = Console.ReadLine();

            } 


        }
    }
}
