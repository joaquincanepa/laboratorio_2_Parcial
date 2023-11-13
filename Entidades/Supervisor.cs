using Entidades.SQL;
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

       private int supervisorId;

        public Supervisor(string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password, int supervisorId, int usuarioId) : base(nombre, apellido, fechaNacimiento, dni, email, password, usuarioId)
        {
            this.SupervisorId = supervisorId;
        }
        public int SupervisorId { get => supervisorId; set => supervisorId = value; }
        public override string ObtenerTipoDeUsuario()//polimorfismo/herencia
        {
            return "Supervisor";
        }
    }
}
