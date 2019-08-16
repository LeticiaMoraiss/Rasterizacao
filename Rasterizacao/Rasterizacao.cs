using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Rasterizacao
{
    class Rasterizacao
    {
        public Queue Imediato(int xInicial, int yInicial, int xFinal, int yFinal)
        {
            double deltaX, deltaY, m, b, yLinha;

            Queue fila = new Queue();
            deltaX = xFinal - xInicial;
            deltaY = yFinal - yInicial;
            m = deltaY / deltaX;
            b = (yInicial - (m * xInicial));

            for (int pos = xInicial; pos <= xFinal; pos++)
            {
                yLinha = (m * pos + b);
                fila.Enqueue(pos);
                fila.Enqueue(Convert.ToInt32(Math.Floor(yLinha)));
            }
            return fila;
        }

        public Queue Brensenham(int xInicial, int yInicial, int xFinal, int yFinal)
        {
            double deltaX, deltaY, decisao, incLeste, incNordeste, y;
            Queue fila = new Queue();

            deltaX = xFinal - xInicial;
            deltaY = yFinal - yInicial;
            decisao = 2 * (deltaY - deltaX);
            incLeste = 2 * deltaY;
            incNordeste = decisao;
            y = yInicial;

            for (int x = xInicial; x <= xFinal; x++)
            {
                if (decisao <= 0)
                {
                    decisao += incLeste;
                }
                else
                {
                    decisao += incNordeste;
                    y++;
                }
                fila.Enqueue(Convert.ToInt32(x));
                fila.Enqueue(Convert.ToInt32(y));
            }
            return fila;
        }
    }
}
