using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Eventos
    {
        public static event Action<string, int> FinDeProduccion;


        public static void Invoke(string producto, int cantidad)
        {
            FinDeProduccion?.Invoke(producto, cantidad);
        }
    }
}
