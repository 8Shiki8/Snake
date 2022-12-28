using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace juego
{
    public class Snake
    {
        private bool vive=true;

        public bool Vive
        {
            get { return vive; }
            set { vive = value; }
        }

        UI marco = new UI();
        private ConsoleKeyInfo teclaVieja = new ConsoleKeyInfo();
        private Cola cola = new Cola();
        private char caracter = 'O';
        public string direccion = "DERECHA";
        public string direccionVieja = "IZQUIERDA";

        public int puntaje{get;set;}
        public int x { get; set; }
        public int y { get; set; }
        public int xOld { get; set; }
        public int yOld { get; set; }
        public char Caracter { get => caracter; set => caracter = value; }
        public Cola Colaa 
        {
            get { return cola; }
            set { cola = value;}
        }

        public void Actualiza()
        {
            if (cola != null)
            {
                cola.x = xOld;
                cola.y = yOld;

            }
           
        }
        public void AgregaCola(Cola cola)
        {
            if (cola.Colaa!=null)
            {
                AgregaCola(cola.Colaa);
            }
            if (cola.Colaa == null)
            {
                cola.Colaa = new Cola();
            }
        }
        public bool ColaMordida(Cola cola,Snake snake)
        {
            if (cola != null)
            {
                if (snake.x == cola.x && snake.y == cola.y)
                {
                    return true;
                }
                if (snake.x != cola.x || snake.y != cola.y)
                {
                    ColaMordida(cola.Colaa,snake);
                }
                return false;
            }
            if (cola == null)
            {
                
                return false;
            }
            return false;
        }
        public void Comportamiento(ConsoleKeyInfo tecla,Comida comida)
        {
            direccion=DireccionFinal(tecla,direccionVieja);

            if (comida.ComidaMordida(this))
            {
               this.puntaje = this.puntaje + 10;
                AgregaCola(this.cola);
                this.cola.Actualiza(xOld,yOld);
            }

         

            if (direccion=="IZQUIERDA")
            {
               
                this.xOld = x;
                this.yOld = y;
                this.Colaa.Actualiza(xOld,yOld);
                this.x--;
                this.direccionVieja = "IZQUIERDA";
                

            }
            if (direccion == "DERECHA")
            {
              
                this.xOld = x;
                this.yOld = y;
                this.Colaa.Actualiza(xOld, yOld);
                this.x++;
                this.direccionVieja = "DERECHA";

                this.teclaVieja = tecla;
            }
            if (direccion == "ABAJO")
            {
                this.xOld = x;
                this.yOld = y;
                this.Colaa.Actualiza(xOld, yOld);
                this.y++;
                this.direccionVieja = "ABAJO";

                this.teclaVieja = tecla;

            }
            if (direccion == "ARRIBA")
            {
                this.xOld = x;
                this.yOld = y;
                this.Colaa.Actualiza(xOld, yOld);
                this.y--;
                this.direccionVieja = "ARRIBA";

                this.teclaVieja = tecla;

            }
        }

        public static string DireccionFinal(ConsoleKeyInfo tecla,string direccionVieja)
        {
           
           

            if (tecla.Key == ConsoleKey.LeftArrow && direccionVieja != "DERECHA")
            {
                return "IZQUIERDA";
            }

           
            if (tecla.Key == ConsoleKey.RightArrow && direccionVieja != "IZQUIERDA")
            {
                return  "DERECHA";
            }
           
            if(tecla.Key == ConsoleKey.UpArrow && direccionVieja != "ABAJO")
            {
                return "ARRIBA";
            }
         
            if (tecla.Key == ConsoleKey.DownArrow && direccionVieja != "ARRIBA")
            {
                return "ABAJO";
            }
            return direccionVieja;
        }
    }
}
