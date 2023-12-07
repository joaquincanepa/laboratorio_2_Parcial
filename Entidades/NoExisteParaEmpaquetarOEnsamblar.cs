using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoExisteParaEmpaquetarOEnsamblar : Exception
    {
        public NoExisteParaEmpaquetarOEnsamblar() : base()
        {
        }

        public NoExisteParaEmpaquetarOEnsamblar(string message) : base(message)
        {
        }

    }
}
