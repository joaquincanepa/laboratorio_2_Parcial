using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializador<T> where T : class, new()
    {
        /// <summary>
        /// Serializa un objeto del archivo y lo devuelve como una instancia del tipo T.
        /// </summary>
        /// <param name="obj">El objeto a serializar.</param>
        /// <returns>True si la operación de serialización fue exitosa, false en caso contrario.</returns>
        public bool Serializar(T obj);

        /// <summary>
        /// Deserializa un objeto del archivo y lo devuelve como una instancia del tipo T.
        /// </summary>
        /// <returns>El objeto deserializado o null si la operación de deserialización falla.</returns>
        public T Deserializar();
    }
}
