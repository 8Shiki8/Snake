using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    public class UI
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
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "██                                                ██",
                                "████████████████████████████████████████████████████"};

        public string[] Marco
        {
            get { return marco; }
            set { marco = value; }
        }

        public bool Colision(Snake snake)
        {
            if (marco[snake.y][snake.x] == '█')
            {
                return true;
            }
            return false;
        }
     }
 }

