using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor : Usuario
    {
        public Supervisor(string nombre, string apellido, DateTime fechaNacimiento, string dni,string email, string password, int usuarioId) 
            : base(nombre, apellido, fechaNacimiento, dni, email, password, usuarioId)
        {

        }

        public override string ObtenerTipoDeUsuario()//polimorfismo/herencia
        {
            return "Supervisor";
        }
    }
}
