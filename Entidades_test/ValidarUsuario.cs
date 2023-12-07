using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Entidades_test
{
    [TestClass]
    public class ValidarUsuarioTest
    {
        [TestMethod]
        public void ValidarUsuario_UsuarioNullOrEmpty()
        {
            // Arrange

            // Act
            bool resultado = Sistema.ValidarUsuario(null, "password");

            // Assert
            Assert.IsFalse(resultado);
            Assert.IsNull(Sistema.UsuarioConectado);
        }

        [TestMethod]
        public void ValidarUsuario_UsuarioValido()
        {
            // Arrange
            // Necesito tener un usuario válido para pasar esta prueba
            // por ejemplo, si en bool resultado = Sistema.ValidarUsuario("@asd", "aa"); Me deberia tirar Falso ya que ese usuario no existe

            // Act
            bool resultado = Sistema.ValidarUsuario("@supervisor", "a");

            // Assert
            Assert.IsTrue(resultado);
            Assert.IsNotNull(Sistema.UsuarioConectado);
            Assert.AreEqual("@supervisor", Sistema.UsuarioConectado.Email);
        }

        [TestMethod]
        public void ValidarUsuario_UsuarioNoValido_NoConectaUsuario()
        {
            // Arrange

            // Act
            bool resultado = Sistema.ValidarUsuario("@supervisor", "contraseñaIncorrecta");

            // Assert
            Assert.IsFalse(resultado);
            Assert.IsNull(Sistema.UsuarioConectado);
        }
    }
}
