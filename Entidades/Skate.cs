using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Skate 
    {
        private int ruedas;
        private int tornillos;
        private int madera;
        private int trucks;
        public Skate()
        {
        }
        public Skate(int ruedas, int tornillos, int madera, int trucks)
        {
            this.Ruedas = ruedas;
            this.Tornillos = tornillos;
            this.Madera = madera;
            this.Trucks = trucks;
        }

        public int Ruedas { get => ruedas; set => ruedas = value; }
        public int Tornillos { get => tornillos; set => tornillos = value; }
        public int Madera { get => madera; set => madera = value; }
        public int Trucks { get => trucks; set => trucks = value; }

    }
}
