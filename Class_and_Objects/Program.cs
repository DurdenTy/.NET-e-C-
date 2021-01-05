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
        public class Ponto{

            public int x, y;

            public Ponto( int x, int y){
                this.x = x;
                this.y = y;
            }
        }

        public class Ponto3D : Ponto{
            int z;

            public Ponto3D(int x, int y, int z) : base(x, y){
                this.z = z;
            }
        }



        static void Main(string[] args)
        {

            Idade adilson = new Idade(23, 180);

            Ponto quadrado = new Ponto(7, 7);

            Ponto3D Cubo = new Ponto3D(7, 7, 7);

        }
    }
}
