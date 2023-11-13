using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RollerEmpaquetado
    {
        private DateTime fechaDefabricacion;
        private string NumeroSerie;
        private string modelo;
        private string nombreDelOperario;
        public RollerEmpaquetado(DateTime fechaDefabricacion, string numeroSerie, string modelo, string nombreDelOperario)
        {
            this.FechaDefabricacion = fechaDefabricacion;
            NumeroSerie1 = numeroSerie;
            this.Modelo = modelo;
            this.NombreDelOperario = nombreDelOperario;
        }
        public DateTime FechaDefabricacion { get => fechaDefabricacion; set => fechaDefabricacion = value; }
        public string NumeroSerie1 { get => NumeroSerie; set => NumeroSerie = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string NombreDelOperario { get => nombreDelOperario; set => nombreDelOperario = value; }
    }
}
