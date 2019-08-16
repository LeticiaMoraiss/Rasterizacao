using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Rasterizacao
{
    class Ponto
    {
        Rasterizacao rasterizacao = new Rasterizacao();
        Queue fila = new Queue();
        char[,] matriz = new char[11, 11];
        public int xInicial { get; set; }
        public int xFinal { get; set; }
        public int yInicial { get; set; }
        public int yFinal { get; set; }

        public void IniciarImediato(int xInicial, int yInicial, int xFinal, int yFinal)
        {
            fila = rasterizacao.Imediato(xInicial, yInicial, xFinal, yFinal);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tImediato");
            ZerarMatriz(matriz);
            PreencherMatriz(matriz, fila);
            Imprimir(matriz);
        }

        public void IniciarBrensenham(int xInicial, int yInicial, int xFinal, int yFinal)
        {
            fila = rasterizacao.Brensenham(xInicial, yInicial, xFinal, yFinal);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tBrensenham");
            ZerarMatriz(matriz);
            PreencherMatriz(matriz, fila);
            Imprimir(matriz);
        }

        public void ZerarMatriz(char[,] matriz)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    matriz[i, j] = '-';
                }
            }
        }

        public void PreencherMatriz(char[,] matriz, Queue fila)
        {
            while (fila.Count > 0)
            {
                matriz[Convert.ToInt32(fila.Dequeue()), Convert.ToInt32(fila.Dequeue())] = '+';
            }
        }

        public void Imprimir(char[,] matriz)
        {
            for (int x = 10; x >= 0; x--)
            {
                for (int y = 0; y < 11; y++)
                {
                    if (matriz[y, x] == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" \u25A0");
                    }
                    else if (matriz[y, x] == '+')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" \u25A0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
