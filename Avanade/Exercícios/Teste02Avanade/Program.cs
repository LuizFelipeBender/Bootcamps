using System;

namespace Teste02Avanade
{
    class Program
    {
        static void Main(string[] args)
       {   
           Console.WriteLine("Digite o número para verificação do quadrado");            
          int n = int.Parse(Console.ReadLine());
          n=n+1;
            for (int i =2 ; i< n;  i=i+2) 
            {
                int b;
                b = i*i;
                Console.WriteLine(i+"^2 = "+ b);
            }
    } 
        /*
          entrada 6
          2^2 = 4
          4^2 = 16
          6^2 = 36
*/
        
        
    }
}
