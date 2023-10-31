using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InventarioSkatesEnsamblados
    {
        private List<SkateEnsamblado> skatesEnsamblados;

        public InventarioSkatesEnsamblados()
        {
            SkatesEnsamblados = new List<SkateEnsamblado>();
        }

        public List<SkateEnsamblado> SkatesEnsamblados { get => skatesEnsamblados; set => skatesEnsamblados = value; }

        public void AgregarSkateEnsamblado(SkateEnsamblado skate)
        {
            SkatesEnsamblados.Add(skate);
        }

    }
}
