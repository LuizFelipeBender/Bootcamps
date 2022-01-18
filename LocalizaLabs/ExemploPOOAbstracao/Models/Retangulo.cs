namespace ExemploPOOAbstracao.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        private bool valid;
    public void Define(double comprimento, double largura)
   {

       if(comprimento > 0 && largura > 0)
       {
       this.comprimento = comprimento;
       this.largura = largura;
       valid = true;
        }
        else
        {
            Console.WriteLine(@"Valores incorretos
            ");
        } 
    }
    public double ObterArea()
    {
        if (valid)
        {
            
        
        return comprimento * largura;
        }
        else
        {
            Console.WriteLine(@"Prencha os valores corretamente...");
            return 0;
        }
    }

    }
}