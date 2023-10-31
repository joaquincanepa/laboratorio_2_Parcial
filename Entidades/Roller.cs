using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Roller
    {
        public enum TipoDeRoller 
        {
            PatinArtistico,
            PatinFreeStyle,
            PatinSobreHielo
        }

        public TipoDeRoller Tipo { get; set; }
        public string NumeroSerie { get; set; }

        public Roller(TipoDeRoller tipo, string numeroSerie)
        {
            Tipo = tipo;
            NumeroSerie = numeroSerie;
        }

        public static bool operator ==(Roller nroSerie1, Roller nroSerie2)
        {

            return nroSerie1.NumeroSerie == nroSerie2.NumeroSerie;
        }

        public static bool operator !=(Roller nroSerie1, Roller nroSerie2)
        {

            return nroSerie1.NumeroSerie != nroSerie2.NumeroSerie;
        }


    }
}
