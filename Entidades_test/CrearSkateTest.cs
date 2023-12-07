using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_test
{
    [TestClass]
    public class CrearSkateTest
    {

        [TestMethod]
        public void CrearSkate_ConMaterialesSuficientes_CreaSkateYDescuentaMateriales()
        {
            // Arrange
            // Configura el stock con suficientes materiales
            Sistema.AgregarMaterial("Ruedas", 4);
            Sistema.AgregarMaterial("Trucks", 2);
            Sistema.AgregarMaterial("Tornillos", 8);
            Sistema.AgregarMaterial("Madera", 1);

            // Guarda la cantidad inicial de materiales
            int ruedasIniciales = Sistema.ObtenerCantidadMaterial("Ruedas");//por ej si pongo ruedas en 0 falla porque no significa qu no tiene ruedas iniciales
            int trucksIniciales = Sistema.ObtenerCantidadMaterial("Trucks");
            int tornillosIniciales = Sistema.ObtenerCantidadMaterial("Tornillos");
            int maderaIniciales = Sistema.ObtenerCantidadMaterial("Madera");

            // Act
            bool resultado = Sistema.CrearSkate();

            // Assert
            // Verifica que el resultado sea verdadero (se pudo crear el skate)
            Assert.IsTrue(resultado, "No se pudo crear el skate.");

            // Verifica que los materiales se descontaron correctamente
            Assert.AreEqual(ruedasIniciales - 4, Sistema.ObtenerCantidadMaterial("Ruedas"), "Las ruedas no se descontaron correctamente.");
            Assert.AreEqual(trucksIniciales - 2, Sistema.ObtenerCantidadMaterial("Trucks"), "Los trucks no se descontaron correctamente.");
            Assert.AreEqual(tornillosIniciales - 8, Sistema.ObtenerCantidadMaterial("Tornillos"), "Los tornillos no se descontaron correctamente.");
            Assert.AreEqual(maderaIniciales - 1, Sistema.ObtenerCantidadMaterial("Madera"), "La madera no se descontó correctamente.");

            // Verifica que se haya creado un skate
            Assert.AreEqual(1, Sistema.ListaDeSkate.Count, "Se esperaba un nuevo skate en la lista.");
        }

    }
}
