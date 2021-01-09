using System;
class Idade{
  static void Main() {
    int quant = 0, idade, i = 0;
    
    while(i < 10){
        Console.WriteLine("Coloque a idade desejada: ");
        idade = Convert.ToInt32(Console.ReadLine());
        i++;
        
        if(idade >= 18){
        quant = quant + 1;
    }
    
    }
    
    
    
    Console.WriteLine("A quantidade de pessoas maior de 18 anos é " + quant);
    
    
  }
}
