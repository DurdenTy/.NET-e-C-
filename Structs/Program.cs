using System;

namespace Structs
{
    class Program
    {
        public enum Cor{
            red = 1, blue, green, orange, yellow, pink, grey, purple
        }

        interface IBox{
            void boxSize();

        }

        interface IFox{
            void foxRun();
        }

        interface FoxInTheBox : IBox, IFox {

            void boxSize(){}
            void foxRun(){}


        }
        static void Main(string[] args)
        {

            
            
            Console.WriteLine();
        
            
        }
    }
}
