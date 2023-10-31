using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo2
{
    public partial class FormSeleccionTipoUsuario : Form
    {
        public FormSeleccionTipoUsuario()
        {
            InitializeComponent();
        }

        private void btncancelarSeleccionTipoUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupervisorSeleccionTipoUsuario_Click(object sender, EventArgs e)
        {
            FormCrearSupervisor frmCrearUsuarioSupervisor = new FormCrearSupervisor();
            frmCrearUsuarioSupervisor.Show();
            Close();
        }

        private void btnOperarioSeleccionTipoUsuario_Click(object sender, EventArgs e)
        {
            FormCrearOperario frmCrearUsuarioOperario = new FormCrearOperario();
            frmCrearUsuarioOperario.Show();
            Close();
        }
    }
}
