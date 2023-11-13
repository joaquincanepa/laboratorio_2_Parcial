using Entidades;
using Entidades.SQL;
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
    public partial class FormCrearOperario : ParcialLabo2.FormCrearSupervisor
    {
        public FormCrearOperario()
        {
            InitializeComponent();
        }


        private void btnCrearUsuarioOperario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreCrearUsuario.Text;
                string apellido = txtApellidoCrearUsuario.Text;
                DateTime fechaNacimiento = dateDechaNacimientoCrearUsuarioOperario.SelectionRange.Start;
                string dni = txtDniCrearUsuario.Text;
                string email = txtEmailCrearUsuario.Text;
                string password = txtPasswordCrearUsuario.Text;

                string error = Sistema.CrearUsuarioSupervisor(nombre, apellido, fechaNacimiento, dni, email, password);

                if (error == null)
                {
                    Operario operario = new Operario(nombre, apellido, fechaNacimiento, dni, email, password, -1,-1);
                    if (Conexion.AgregarOperario(operario))
                    {
                        Sistema.ListaDeUsuarios.Add(operario);
                        MessageBox.Show("Usuario Operario creado correctamente.");
                        Close();
                    }
                    else 
                    {
                        MessageBox.Show("Error al agregar el operario");
                    }             
                }
                else
                {
                    throw new Exception(error.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                LogErrores.RegistrarError(ex.Message,typeof(FormCrearOperario).Name,nameof(btnCrearUsuarioOperario));

            }

        }

        private void btnLimpiarDatosCrearUsuario_Click(object sender, EventArgs e)
        {
   
            txtApellidoCrearUsuario.Text = string.Empty;
            txtNombreCrearUsuario.Text= string.Empty;
            txtPasswordCrearUsuario.Text=string.Empty;
            txtEmailCrearUsuario.Text = string.Empty;
            txtDniCrearUsuario.Text = string.Empty;
            dateDechaNacimientoCrearUsuarioOperario.SetDate(DateTime.Now);

        }
    }
}
