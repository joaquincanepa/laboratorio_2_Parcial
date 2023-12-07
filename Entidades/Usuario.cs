using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Operario))] // Agrega esta línea para incluir Operario en la serialización
    [XmlInclude(typeof(Supervisor))]
    public abstract class Usuario//aplico polimorfismo a traves de abstract
                                 //ya q no instancio un usuario en si
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string dni;
        private string email;
        private string password;
        int idUsuario;
        public Usuario(string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password, int idUsuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
            this.email = email;
            this.password = password;
            this.IdUsuario = idUsuario;
        }

        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        /// <summary>
        /// Valida si el email y la contraseña proporcionados son iguales a los del usuario actual.
        /// </summary>
        /// <param name="emailUsuario">El email del usuario a validar.</param>
        /// <param name="passwordUsuario">La contraseña del usuario a validar.</param>
        /// <returns>True si el email y la contraseña son válidos, de lo contrario, false.</returns>
        public bool ValidarUsuario(string emailUsuario, string passwordUsuario)
        {
            if (this.email == emailUsuario && this.password == passwordUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract string ObtenerTipoDeUsuario();//aplico polimosrfismo
    }
}
