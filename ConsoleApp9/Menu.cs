using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Menu
    {
        private string[] marco ={ "████████████████████████████████████████████████████",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                  [ ] START                     ██",
                                "██                  [ ] SALIR                     ██",
                                "██                                                ██",
                                "██                                                ██",
                                "████████████████████████████████████████████████████"};

        public string[] Marco
        {
            get { return marco; }
            set { marco = value; }
        }
       
        public void menuSelection()
        {
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan };
          
            int x=21;
            int y=13;
            for (int i = 0; i < marco.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                       ");
                Console.SetCursorPosition(0, i);
                Console.Write(Marco[i]);
            }
            Console.SetCursorPosition(x, y);
            Console.Write("■");
           
            
            
          

            while (tecla.Key != ConsoleKey.Enter)
            {
                foreach (var color in colors)
                {
                    Titulo(color);

                }

                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < marco.Length; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("                                                       ");
                    Console.SetCursorPosition(0, i);
                    Console.Write(Marco[i]);
                }

                if (tecla.Key==ConsoleKey.UpArrow)
                {
                    x = 21;
                    y = 13;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x,y);
                    Console.Write("■");
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    x = 21;
                    y = 14;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x, y);
                    Console.Write("■");


                }
                else 
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("■");
                }
                 System.Threading.Thread.Sleep(30);
                if (Console.KeyAvailable == true)
                {
                    tecla = Console.ReadKey();
                }
            }

            if (y==14) 
            {
                Environment.Exit(0);
                Console.WriteLine("saliste");
            }
        }

        public void Titulo(ConsoleColor color)
        {
            string[] marco2 ={ "██████ ███   ███ ████████ ███  ███ ██████",
                               "███    █████████ ███  ███ ███ ███  ███   ",
                               "██████ ███  ████ ████████ ██████   █████ ",
                               "   ███ ███   ███ ███  ███ ███ ███  ███   ",
                               "██████ ███   ███ ███  ███ ███  ███ ██████"
                                };
            for (int i = 0; i < marco2.Length; i++)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(5, i+5);
                Console.Write("                         ");
                Console.SetCursorPosition(5, i+5);
                Console.Write(marco2[i]);
                System.Threading.Thread.Sleep(10);

            }
        }
    }
}
