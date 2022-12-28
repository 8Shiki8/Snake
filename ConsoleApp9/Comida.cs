using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    public class Comida
    {
        private char caracter = '*';

        public char Caracter
        {
            get { return caracter; }
            set { caracter = value; }
        }

        public int x { get; set; }
        public int y { get; set; }

        public bool ComidaMordida (Snake snake)
        {
            Random random = new Random();
            if (snake.x==this.x&&snake.y==this.y)
            {
                this.x = random.Next(2, 25);
                this.y = random.Next(2, 16);
                return true;
            }
            return false;
        }

    }
}
