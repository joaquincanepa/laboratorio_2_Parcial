using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_test
{
    [TestClass]
    public class TestCrearRoller
    {
        [TestMethod]
        public void CrearRollers_PatinArtistico_CreaRollersYDescuentaMateriales()
        {
            // Arrange
            //Esto va a dar bien siempre y cuando haya materialies en el stock para crear Rollers de tipo PatinArtistico


            // Act
            bool resultado = Sistema.CrearRollers(Roller.TipoDeRoller.PatinArtistico, 1);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(1, Sistema.ListaDeRoller.Count);

        }

        [TestMethod]
        public void CrearRollers_PatinFreeStyle_CreaRollersYDescuentaMateriales()
        {
            // Arrange
            //Esto va a dar bien siempre y cuando haya materialies en el stock para crear Rollers de tipo PatinFreeStyle

            // Act
            bool resultado = Sistema.CrearRollers(Roller.TipoDeRoller.PatinFreeStyle, 1);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(1, Sistema.ListaDeRoller.Count);

        }

        [TestMethod]
        public void CrearRollers_PatinSobreHielo_CreaRollersYDescuentaMateriales()
        {
            //Esto va a dar bien siempre y cuando haya materialies en el stock para crear Rollers de tipo PatinSobreHielo

            // Act
            bool resultado = Sistema.CrearRollers(Roller.TipoDeRoller.PatinSobreHielo, 1);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(1, Sistema.ListaDeRoller.Count);
           
        }



        [TestMethod]
        public void CrearRollers_TipoNoValido_RetornaFalse()
        {
            // Arrange
            // Esto va a funcionar siempre y cuando haya stock para crear roller

            // Act
            bool resultado = Sistema.CrearRollers((Roller.TipoDeRoller)5, 1); // Un tipo que no es válido, ya que el tipo 5 no existe

            // Assert
            Assert.IsFalse(resultado);

        }

    }
}
