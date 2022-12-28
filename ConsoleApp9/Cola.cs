using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    public class Cola
    {
        private Cola cola = null;

        public Cola Colaa
        {
            get { return cola; }
            set { cola = value; }
        }
        public int x { get; set; }
        public int y { get; set; }
        public int xOld { get; set; }
        public int yOld { get; set; }
        public void Actualiza(int x1,int y1)
        {
            if (cola != null)
            {
                
                xOld = x;
                yOld = y;
                x = x1;
                y = y1;
                cola.Actualiza(xOld, yOld);
            }
            if (cola == null)
            {

                xOld = x;
                yOld = y;
                x = x1;
                y = y1;
               
            }

        }
    }
}
