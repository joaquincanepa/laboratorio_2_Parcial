using CanepaJoaquinParcial;
using Entidades;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            OcultarSubMenu();
            Estilos.CargarEstilosDeljson();
            btn_MostrarUsuarios.Visible = false;
            if (Sistema.UsuarioConectado.ObtenerTipoDeUsuario() == "Supervisor")
            {
                btn_MostrarUsuarios.Visible = true;
            }
        }
        private void OcultarSubMenu()
        {
            pnl_Stock.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnl_Stock.Visible == true)
            {
                pnl_Stock.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmFotoMenuPrincipal());
        }

        private void btnCrearSkate_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearSkate());
        }


        private void btnFabricarRollers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearRollers());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListaStock());
            if (Sistema.UsuarioConectado.ObtenerTipoDeUsuario() == "Supervisor")
            {
                MostrarSubMenu(pnl_Stock);
            }

        }

        public Form FormActivo = null;
        /// <summary>
        /// Abre un formulario secundario dentro de un formulario principal
        /// Si ya hay un formulario activo, lo cierra para asegurarse de que solo un formulario secundario esté visible a la vez.
        /// Configura el formulario secundario para meterlo en el formulario principal sin un borde visible.
        /// Ajusta el formulario secundario para que ocupe todo el espacio disponible
        /// Agrega el formulario secundario como un control en el contenedor especificado.
        /// Almacena una referencia al formulario secundario en la propiedad "Tag" del control contenedor para futuras referencias.
        /// Lleva el formulario secundario al frente, asegurando que sea visible por encima de otros controles en el formulario principal.
        /// Muestra el formulario secundario, haciéndolo visible para el usuario.
        /// </summary>
        /// <param name="childForm">El formulario secundario que se abrirá dentro del formulario principal.</param>
        public void openChildForm(Form childForm)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_MenuPrincipal.Controls.Add(childForm);
            pnl_MenuPrincipal.Tag = childForm;
            childForm.BringToFront();
            Estilos.ActualizarTamanioFuente(childForm);
            childForm.Show();
        }

        private void btn_ReponerStock_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReponerStock());
        }

        private void btn_MostrarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListaUsuarioscs());
        }

        private void btn_misDatos_Click(object sender, EventArgs e)
        {
            openChildForm(new CuentaMisDatos());
        }

        private void btn_tamanioFuente_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTamanioFuente());
        }
    }
}
