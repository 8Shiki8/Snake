using juego;
using System;

using System.Timers;


namespace ConsoleApp9
{
    class Program
    {
        public static ConsoleKeyInfo tecla;
        static void Main(string[] args)
        {
            //COMENTARIO EN MASTER
            //COMEMNTARIO EN MASTER 2
            //  COMENTARIO RAMA1
            // Se configura la ventana
            Console.SetWindowSize(60, 20);
            Console.SetBufferSize(60, 20);
            Console.CursorVisible = false;
            Timer timer = new Timer(1);
            
            //Se inicializa las posiciones por defecto
            Snake snake = new Snake();
            snake.x = 20;
            snake.y = 4;
            snake.Colaa.y = 4;
            snake.Colaa.x = 21;
            snake.Colaa.Colaa = new Cola();
            snake.Colaa.Colaa.y = 4;
            snake.Colaa.Colaa.x = 22;

            UI marco = new UI();

            Comida comida = new Comida();
            comida.x = 18;
            comida.y = 2;
            Menu menu = new Menu();

            //MENU DEL JUEGO
            menu.menuSelection();

            timer.Elapsed += (obj, sender) => GuardaTecla();
            timer.Start();

            //BUCLE GENERAL
            while (snake.Vive)
            {

               
                snake.Comportamiento(tecla, comida);
                System.Threading.Thread.Sleep(300);
                if (!marco.Colision(snake) == false ||!ColaMordida(snake.Colaa, snake) == false)
                {
                    snake.Vive = false;
                }
                Printer.PrintAll(snake, comida);


            }

            ConsoleColor[] colors1 = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan };
            ConsoleColor[] colors2 = { ConsoleColor.Yellow, ConsoleColor.Cyan,ConsoleColor.Red };
            ConsoleColor[] colors3 = { ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Yellow };

            while (true)
            {
                GameOver(colors1);
                GameOver(colors2);
                GameOver(colors3);

            }


        }

        public static void GameOver(ConsoleColor[] colors2)
        {
            ConsoleColor[] colors = colors2;
            int cont = 0;
            
            bool letraColoreada = false;
            string texto = "GAME OVER";
            
                for (int i = 0; i < texto.Length; i++)
                {
                    while (letraColoreada == false )
                    {
                        Console.ForegroundColor = colors[cont];

                        Console.SetCursorPosition(21 + i, 8);
                        Console.Write(texto[i]);
                        cont++;
                        if (colors.Length == cont)
                        {
                            cont = 0;
                        }
                        letraColoreada = true;


                    }
                    letraColoreada = false;
                }
         
            System.Threading.Thread.Sleep(300);


        }

        public static bool ColaMordida(Cola cola, Snake snake)
        {
            if (cola == null)
            {
                return false;

            }
            if (snake.x == cola.x && snake.y == cola.y)
            {
                return true;
            }
            if (snake.x != cola.x || snake.y != cola.y)
            {
               return ColaMordida(cola.Colaa, snake);
            }
            else
                return false;
            
        }
        public static ConsoleKeyInfo GuardaTecla()
        {
            

            tecla = Console.ReadKey();
            
            return tecla;
        }
    }
}
