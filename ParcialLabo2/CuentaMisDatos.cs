using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanepaJoaquinParcial
{
    public partial class CuentaMisDatos : Form
    {
        public CuentaMisDatos()
        {
            InitializeComponent();
        }

        private void CuentaMisDatos_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Sistema.UsuarioConectado.Nombre;
            txtApellido.Text = Sistema.UsuarioConectado.Apellido;
            txtDocumento.Text = Sistema.UsuarioConectado.Dni;
            txtEmail.Text = Sistema.UsuarioConectado.Email;
            txtFechaNacimiento.Text = Sistema.UsuarioConectado.FechaNacimiento.ToString("dd/MM/yyyy");
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDocumento.Enabled = true;
            txtEmail.Enabled = true;
            txtFechaNacimiento.Enabled = true;
        }

        private void btnConfirmarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string documento = txtDocumento.Text;
                string email = txtEmail.Text;
                DateTime fechaNacimiento = DateTime.ParseExact(txtFechaNacimiento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Validar los campos si es necesario

                Sistema.ModificarDatosPersonales(nombre, apellido, fechaNacimiento, documento, email);

                MessageBox.Show("Los cambios han sido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogErrores.RegistrarError(ex.Message, typeof(CuentaMisDatos).Name, nameof(btnConfirmarDatos_Click));
            }

            // Deshabilitar los controles
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDocumento.Enabled = false;
            txtEmail.Enabled = false;
            txtFechaNacimiento.Enabled = false;
        }
    }
}
