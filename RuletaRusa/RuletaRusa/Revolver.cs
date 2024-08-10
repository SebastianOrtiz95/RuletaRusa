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
            posicionActual = Metodos.numeroAleatorio(1,6);
            posicionBala = Metodos.numeroAleatorio(1,6);
        }


        // disparar(): devuelve true si la bala coincide con la posición actual
        public bool disparar()
        {
            if (posicionActual == posicionBala)
            {
                return true;
            }
            else
                return false;
        }

        // siguienteBala(): cambia a la siguiente posición del tambor
        public void siguienteBala()
        {
            if (posicionActual==6)
            {
                posicionActual = 1;
            }else
                posicionActual++;   
        }
        public override string ToString()
        {
            return "Posicion Actual: " + posicionActual + " Posicion de la Bala: " + posicionBala;
        }
       
    }
}
