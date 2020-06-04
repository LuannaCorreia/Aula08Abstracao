using System;

namespace Aula08POOAbstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3600f;

            System.Console.WriteLine("Deseja realizar quanto de acréscimo no seu limite?");
            float acrescimo = float.Parse( Console.ReadLine() );

            visa.AumentarLimite( acrescimo );
            System.Console.WriteLine("Seu novo limite é: R$"+visa.limite);
            
        }
    }
}
