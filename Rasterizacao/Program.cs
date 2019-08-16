using System;
using System.Collections;
using System.Collections.Generic;

namespace Rasterizacao
{
    class Program
    {
        static void Main()
        {
            Ponto ponto = new Ponto();

            Console.WriteLine("\n\tBem Vindo ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Pontos Iniciais: (1,2)");
            Console.WriteLine(" Pontos Finais: (9,8)");

            ponto.IniciarImediato(1, 2, 9, 8);
            ponto.IniciarBrensenham(1, 2, 9, 8);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("\tFim!!");
            Console.WriteLine("\n Pressione uma tecla para finalizar!!");
            Console.ReadKey();
        }
    }
}
