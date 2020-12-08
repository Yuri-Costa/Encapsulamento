using System;
namespace Encapsulamento2
{
    public class Cartao
    {
        //atributos
        private string nomeTitular;
        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        private string bandeira;
        private string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "qwertyui";
         public string Token{
            get{return token;}
        }
        private string cvv;
        
        protected float limite = 5000;

        
        public string ReceberNome(string nomeDigitado){
            return nomeTitular = nomeDigitado;
        }
        public void ExibirNome(){
            Console.WriteLine(this.nomeTitular);
        }
        public bool RegistrarCompra(bool validado){
            return true;
        }

        private bool ValidarCompra(float saldo){
            return true;
        }

        public string ValidarToken(){
            return this.Token;
        }

    }
}