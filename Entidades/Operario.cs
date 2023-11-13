using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operario : Usuario
    {
        public Operario(string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password, int usuarioId)
            : base(nombre, apellido, fechaNacimiento, dni, email, password, usuarioId)
        {
        }


        int idOperario;
        public Operario(string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password, int Id, int idUsuario) : base(nombre, apellido, fechaNacimiento, dni, email, password, idUsuario)
        {
            this.idOperario = Id;
        }

        public int IdOperario { get => idOperario; set => idOperario = value; }
        public override string ObtenerTipoDeUsuario()//polimorfismo/herencia
        {
            return "Operario";
        }
    }
}
