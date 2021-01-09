using System;
class Idade{
  static void Main() {
      
    double sal;
    
   
    Console.Write("Coloque o seu salário para o reajuste: ");
    sal = Convert.ToDouble(Console.ReadLine());

        
    if(sal >= 300){
    sal = sal + (sal * 30)/100;
    }else{
        sal = sal + (sal * 50)/100;
    }
    
    Console.WriteLine("Seu salário com o reajuste será: R$" + sal);
    
    
    
  }
}
