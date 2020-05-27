using System;

namespace Aula_POO_celular
{
    class Program
    {
        static void Main(string[] args)
        {
            celulares motorola = new celulares();
            motorola.modelo = "moto g7";
            motorola.cor = " vermelho";
            motorola.tamanho = 6.2f ;
            motorola.ligado = true;

            Console.WriteLine("Deseja o celular ligado?");
            motorola.ligado = motorola.TraduzConsole(Console.ReadLine());

            Console.WriteLine("Seu celular pode ligar, desligar, fazer ligação e enviar mensagem.");
            motorola.ligado = motorola.TraduzConsole(Console.ReadLine());

            

        }
    }
}
