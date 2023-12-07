using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanepaJoaquinParcial
{
    public partial class FrmTamanioFuente : Form
    {
        public FrmTamanioFuente()
        {
            InitializeComponent();
            Estilos.CargarEstilosDeljson();
        }


        private void radMediano_CheckedChanged(object sender, EventArgs e)
        {
            Estilos.CambiarTamanoFuente(10f, this);
        }

        private void radGrande_CheckedChanged(object sender, EventArgs e)
        {
            Estilos.CambiarTamanoFuente(12f, this);
        }

        private void radXl_CheckedChanged(object sender, EventArgs e)
        {
            Estilos.CambiarTamanoFuente(15f, this);
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Estilos.GuardarConfiguracion();
        }
    }
}
