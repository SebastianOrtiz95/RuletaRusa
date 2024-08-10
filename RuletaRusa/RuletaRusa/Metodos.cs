using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaRusa
{
    public class Metodos
    {
        private static Random random = new Random();
        public static int numeroAleatorio(int minimo,int maximo)
        {
            int numero=random.Next(minimo,maximo);
            return numero;
        }
    }
}
