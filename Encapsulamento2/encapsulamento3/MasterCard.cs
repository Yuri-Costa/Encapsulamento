using System;

namespace Encapsulamento2
{
    public class MasterCard : Cartao
    {
        
        private int parcelas;

        public string CompraComDesconto(){
            return "";
        }

        public void ExibirLimite(){
            Console.WriteLine(this.limite);
        }
        

        }
    }
