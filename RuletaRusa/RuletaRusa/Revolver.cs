using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaRusa
{
    public class Revolver
    {
        private int posicionActual;
        private int posicionBala;

        public Revolver()
        {
            posicionActual = 0;
            posicionBala = 0;
        }

        public bool disparar()
        {

        }
        public void siguienteBala()
        {

        }
        public override string ToString()
        {
            return "Posicion Actual: " + posicionActual + " Posicion de la Bala: " + posicionBala;
        }
    }
}
