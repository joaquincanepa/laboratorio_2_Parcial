using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Eventos
    {
        /// <summary>
        /// Evento que se dispara al finalizar la producción de un producto.
        /// Proporciona información sobre el producto y la cantidad producida.
        /// </summary>
        public static event Action<string, int> FinDeProduccion;


        /// <summary>
        /// Invoca el evento de fin de producción, proporcionando información sobre el producto y la cantidad producida.
        /// </summary>
        /// <param name="producto">Nombre del producto producido.</param>
        /// <param name="cantidad">Cantidad del producto producido.</param>
        public static void Invoke(string producto, int cantidad)
        {
            FinDeProduccion?.Invoke(producto, cantidad);//si no es null hay suscriptores para el evento entonces llama al metodo
        }
    }
}
