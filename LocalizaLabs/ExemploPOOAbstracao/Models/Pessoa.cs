using System;
namespace ExemploPOOAbstracao.Models
{
    public class Pessoa
    {
        public string Name  { get; set; }
        public int Idade { get; set; }
        
        public long cpf { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"My name is {Name}, my age is {Idade}");
        }

    }
}