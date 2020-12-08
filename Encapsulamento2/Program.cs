using System;

namespace Encapsulamento2
 
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

          m.ReceberNome("Yuri Costa Camilo");
          m.ExibirNome();

          m.Numero ="54321";
          Console.WriteLine(m.Numero);
          
          m.ValidarToken();
        }
    }
}
