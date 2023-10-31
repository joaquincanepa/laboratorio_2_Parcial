
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlStock
    {
        private static ControlStock instacia;
        public Dictionary<string, int> StockMateriaPrima { get; private set; }
        

        public ControlStock()
        {
            StockMateriaPrima = new Dictionary<string, int>
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
                 //cuero, cierre, cordones, fibra de carbono
                { "Cuchilla", 100 },
            };
        }


       
        public bool DescontarMaterial(string material, int cantidad)
        {
            if (StockMateriaPrima.ContainsKey(material) && StockMateriaPrima[material] >= cantidad)
            {
                StockMateriaPrima[material] -= cantidad;
                return true;
            }
            return false;
        }

        public void AgregarMaterial(string material, int cantidad)
        {
            if (StockMateriaPrima.ContainsKey(material))
            {
                StockMateriaPrima[material] += cantidad;
            }
            else
            {
                StockMateriaPrima.Add(material, cantidad);
            }
        }

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
