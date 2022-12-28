using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    public class Printer
    {
        public static void PrintAll(Snake snake,Comida comida)
        {
            UI marco = new UI();
            for (int i = 0; i < marco.Marco.Length; i++)
            {
                
                Console.SetCursorPosition(0, i);
                Console.Write("                                                             ");
                Console.SetCursorPosition(0,i);
                Console.Write(marco.Marco[i]);
            }
            Console.SetCursorPosition(snake.x,snake.y);
            Console.Write(snake.Caracter);
            PrintCola(snake.Colaa);
            Console.SetCursorPosition(comida.x,comida.y);
            Console.Write(comida.Caracter);
            Console.SetCursorPosition(2, 18);
            Console.Write("PUNTAJE:{0}",snake.puntaje);

        }

        public static void PrintCola(Cola cola)
        {
            if (cola.Colaa != null)
            {
                Console.SetCursorPosition(cola.x, cola.y);
                Console.Write('O');
                PrintCola(cola.Colaa);

            }
            if (cola.Colaa == null)
            {
                Console.SetCursorPosition(cola.x, cola.y);
                Console.Write('O');
            }
        }
    }
}
