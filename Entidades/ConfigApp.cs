using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConfigApp
    {
        Single tamanio;
        public ConfigApp()
        {
            // Constructor sin parámetros
        }


        public ConfigApp(Single tamanio)
        {
            this.Tamanio = tamanio;

        }

        public Single Tamanio { get => tamanio; set => tamanio = value; }
    }
}
