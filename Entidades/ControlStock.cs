
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class SerializableStock//clase para poder serializar
    {
        public List<StockItem> StockMateriaPrima { get; set; }
    }

    [Serializable]
    public class StockItem//para la serializacion
    {
        public string Material { get; set; }
        public int Cantidad { get; set; }
    }


    [XmlInclude(typeof(Dictionary<string, int>))]
    [Serializable]
    public class ControlStock
    {
        private static ControlStock instacia;
        public SerializableStock SerializableStock { get; private set; }//para la serializacion
        public Dictionary<string, int> StockMateriaPrima { get; private set; }      
        private ControlStock()
        {
            SerializableStock = new SerializableStock();//para la serializacion
            /*StockMateriaPrima = new Dictionary<string, int>
            {
                { "Madera", 88 },
                { "Ruedas", 100 },
                { "Tornillos", 200 },
                { "Trucks", 150 }
                ,//Para Roller Patin artistico
                { "BotaDeCuero",150},
                { "Aluminio",150},
                { "TacoDelantero", 100 },
                { "Cordones", 100 },
                //Para patin freeSkate
                { "BotasDePlastico", 100 },
                { "FibraDeCarbono", 100 },
                { "Cierre", 100 },
                 //Para patin SobreHielo
                { "Cuchilla", 100 },
            };*/
            CargarStockDesdeXml();
        }


        /// <summary>
        /// Carga el stock desde un archivo XML en la instancia actual del ControlStock.
        /// </summary>
        public void CargarStockDesdeXml()
        {
            SerializadorXml<SerializableStock> serializador = new SerializadorXml<SerializableStock>("controlStock.xml");
            SerializableStock stockDesdeXml = serializador.Deserializar();

            if (stockDesdeXml != null && stockDesdeXml.StockMateriaPrima != null)
            {
                // Actualizar el stock en la instancia actual
                StockMateriaPrima = stockDesdeXml.StockMateriaPrima.ToDictionary(item => item.Material, item => item.Cantidad);
            }
        }
        /// <summary>
        /// Guarda el stock actual en un archivo XML.
        /// </summary>
        public void GuardarStockEnXml()
        {
            // Guardar el stock actual en el archivo XML
            SerializableStock stockParaGuardar = new SerializableStock { StockMateriaPrima = StockMateriaPrima.Select(item => new StockItem { Material = item.Key, Cantidad = item.Value }).ToList() };
            SerializadorXml<SerializableStock> serializador = new SerializadorXml<SerializableStock>("controlStock.xml");
            serializador.Serializar(stockParaGuardar);
        }


        /// <summary>
        /// Descontar la cantidad especificada del material del stock si hay suficiente.
        /// </summary>
        /// <param name="material">El material a descontar.</param>
        /// <param name="cantidad">La cantidad a descontar.</param>
        /// <returns>True si se pudo descontar, false si no hay suficiente cantidad en el stock.</returns>
        public bool DescontarMaterial(string material, int cantidad)
        {
            if (StockMateriaPrima.ContainsKey(material) && StockMateriaPrima[material] >= cantidad)
            {
                StockMateriaPrima[material] -= cantidad;
                GuardarStockEnXml();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega la cantidad especificada del material al stock. incrementa la cantidad, 
        /// de lo contrario, agrega el material al stock.
        /// </summary>
        /// <param name="material">El material a agregar.</param>
        /// <param name="cantidad">La cantidad a agregar.</param>
        public void AgregarMaterial(string material, int cantidad)
        {
            if (StockMateriaPrima.ContainsKey(material))
            {
                StockMateriaPrima[material] += cantidad;
                GuardarStockEnXml();
            }
            else
            {
                StockMateriaPrima.Add(material, cantidad);
            }
        }

        /// <summary>
        /// Obtiene la instancia única del ControlStock. Si no existe, crea una nueva instancia.
        /// </summary>
        /// <returns>La instancia única del ControlStock.</returns>
        public static ControlStock GetInstance()
        {
            if (instacia == null)
            {
                instacia = new ControlStock();
            }
            return instacia;
        }
    }
}
