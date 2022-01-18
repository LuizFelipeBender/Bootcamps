using System;
using ExemploPOOAbstracao.Models;
namespace ChamaPessoa
{
    public class Pessoas {
        
        static void Main(string[] args)
        {
             // Heranca METHOD
              Professor p1 = new Professor();
              p1.Salary= 18;
              p1.Name = "Luiz Bender";
              p1.Idade= 21;
              p1.cpf = 32132131313231;
              p1.Apresentar();
            //Encasulamento
            // Retangulo r = new Retangulo();
            // r.Define(30,30);
            // Console.WriteLine($"Área: {r.ObterArea()}"); 
            // Retangulo r2 = new Retangulo();
            // r2.Define(0,0);
            // Console.WriteLine($"Área: {r2.ObterArea()}");
            
            // ABSTRACT METHOD
            //  Pessoa p1 = new Pessoa();
            //  p1.Name = "Luiz Bender";
            //  p1.Idade= 21;
            //  p1.cpf = 32132131313231;
            //  p1.Apresentar();
        }
    }

}