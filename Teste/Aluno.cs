using System;
namespace Encapsulamento
{
     class Aluno
    {
        //atributos
        private double nota1 , nota2;


        //media
        private double media(){
            return (nota1 + nota2) / 2;
     
            }
            //mensagem
            public void mensagem(){
                Console.ForegroundColor=ConsoleColor.Cyan;
                Console.WriteLine("informe a primeira nota");
                nota1 = int.Parse(Console.ReadLine());

                Console.WriteLine("informe a segunda nota");
                nota2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"A sua media é {+ media()} ");

        }



        
        
    }
}