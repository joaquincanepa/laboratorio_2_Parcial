using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_test
{
    [TestClass]
    public class TestValidarDniYEmail
    {
        [TestMethod]
        public void CrearUsuarioSupervisor_EntradaValida_RetornaNulo()//debe retornar nulo ya que mi metodo si sale todo ok retorna nulo
        {
            // Arrange
            string nombre = "Joaquin";
            string apellido = "Gonzalez";
            DateTime fechaNacimiento = new DateTime(1999, 1, 1);
            string dni = "42175301";
            string email = "@hola";
            string password = "a";

            // Act
            string resultado = Sistema.CrearUsuarioSupervisor(nombre, apellido, fechaNacimiento, dni, email, password);

            // Assert
            Assert.IsNull(resultado, "El resultado debería ser nulo para una entrada válida.");
        }

        [TestMethod]
        public void CrearUsuarioSupervisor_CamposFaltantes_RetornaMensajeDeError()
        {
            // Arrange
            string nombre = "";
            string apellido = "Doe";
            DateTime fechaNacimiento = new DateTime(1990, 1, 1);
            string dni = "12345678";
            string email = "@jose";
            string password = "ab";

            // Act
            string resultado = Sistema.CrearUsuarioSupervisor(nombre, apellido, fechaNacimiento, dni, email, password);

            // Assert
            Assert.AreEqual("Por favor, complete todos los campos.", resultado, "Debería devolver un mensaje de error para campos faltantes.");
        }

    }
}
