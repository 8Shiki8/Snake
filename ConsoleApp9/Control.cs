using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    public class Control
    {
        public static void Movimiento(ConsoleKeyInfo tecla,Snake snake,UI marco,Comida comida)
        {
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                snake.xOld = snake.x;
                snake.yOld = snake.y;
                snake.Colaa.Actualiza(snake.xOld, snake.yOld);
                snake.x++;
               
                if (marco.Colision(snake))
                {
                   
                    snake.x--;
                }
            }
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                snake.xOld = snake.x;
                snake.yOld = snake.y;
                snake.Colaa.Actualiza(snake.xOld, snake.yOld);
                snake.x--;
                
                if (marco.Colision(snake))
                {
                    snake.x++;
                }
            }
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                snake.xOld = snake.x;
                snake.yOld = snake.y;
                snake.Colaa.Actualiza(snake.xOld, snake.yOld);
                snake.y--;
                if (marco.Colision(snake))
                {
                    snake.y++;
                }
            }
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                snake.xOld = snake.x;
                snake.yOld = snake.y;
                snake.Colaa.Actualiza(snake.xOld, snake.yOld);
                snake.y++;
                if (marco.Colision(snake))
                {
                    snake.y--;
                }
            }

           
        }
    }
}
