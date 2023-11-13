using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public interface IModificlable<T>
    {
        public List<T> Traer();
        public List<T> Traer(int id);//sobreCarga
        public bool Borrar(int id);
        public bool Agregar(T objeto);
        public bool Editar(T objeto);

    }
}
