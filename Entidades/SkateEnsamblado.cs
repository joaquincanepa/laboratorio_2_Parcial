using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SkateEnsamblado
    {
        private DateTime fechaFabricacion;
        private string numeroSerie;
        private string modelo;

        public DateTime FechaFabricacion { get => fechaFabricacion; set => fechaFabricacion = value; }
        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public SkateEnsamblado(DateTime fechaFabricacion, string numeroSerie, string modelo)
        {
            FechaFabricacion = fechaFabricacion;
            NumeroSerie = numeroSerie;
            Modelo = modelo;
        }
    }
}
