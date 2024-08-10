using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaRusa
{
    public class Juego
    {
        //• Juego:
        //            o Atributos:
        // Jugadores(conjunto de Jugadores)
        // Revolver
        //o Funciones:
        // finJuego(): cuando un jugador muere, devuelve true
        // ronda(): cada jugador se apunta y se dispara, se informara del estado de la partida(El jugador se dispara, no ha muerto en esa ronda, etc.)
        private Jugador[] jugadores;
        private Revolver revolver;

        public Juego(int jugadores)
        {
            if (jugadores>6)
            {
                this.jugadores = new Jugador[6];
            }else
              this.jugadores = new Jugador[jugadores];


            cargarJugadores();
            this.revolver = new Revolver();
        }

        public bool finJuego()
        {
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (!jugadores[i].Vivo)
                {
                    return true;
                }
            }
            return false;
        }
        public void ronda()
        {
            int i = 0;
            while (jugadores[i].Vivo)
            {
                
                if (jugadores[i].disparar(revolver))
                {
                    Console.WriteLine(jugadores[i].Nombre + " " + jugadores[i].Id + " Se dispara");
                    Console.WriteLine(jugadores[i].ToString());
                }
                else
                {
                    Console.WriteLine(jugadores[i].Nombre + " " + jugadores[i].Id + " Se dispara");
                    Console.WriteLine(jugadores[i].ToString());
                    return;
                }
                revolver.siguienteBala();
                i++;
                if (i == jugadores.Length)
                {
                    i = 0;
                }
            }
        }
        public void cargarJugadores()
        {
            for(int i = 0;i < jugadores.Length;i++)
            {
                jugadores[i] = new Jugador(i+1);
            }
        }
        public int Jugadores
        {
            get { return jugadores.Length; }
        }
    }
}
