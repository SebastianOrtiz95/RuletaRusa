using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaRusa
{
    public class Jugador
    {
        private int id = 0;
        private string nombre;
        private bool vivo;

        public Jugador(int id)
        {
            nombre = "Jugador";
            vivo = true;
            this.id=id;
        }


        // disparar(Revolver r): el jugador se apunta y se dispara, si la bala se dispara, el jugador muere.
        public bool disparar(Revolver r)
        {
            if (r.disparar())
            {
                return vivo = false;
            }
            return vivo;
        }
        public override string ToString() 
        {
            if (!vivo)
            {
                return nombre + " " + id + " muerto";
            }
            else
                return nombre + " " + id + " sigue vivo";
            
        }
        public bool Vivo
        {
            get { return vivo; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Id
        {
            get { return id; }
        }
    }
}
