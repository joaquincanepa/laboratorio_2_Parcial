﻿using Entidades;
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
    public partial class FormCrearSupervisor : Form
    {
        public FormCrearSupervisor()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreCrearUsuario.Text;
                string apellido = txtApellidoCrearUsuario.Text;
                DateTime fechaNacimiento = dateFechaNacimientoCrearUsuario.SelectionRange.Start;
                string dni = txtDniCrearUsuario.Text;
                string email = txtEmailCrearUsuario.Text;
                string password = txtPasswordCrearUsuario.Text;

                string error = Sistema.CrearUsuarioSupervisor(nombre, apellido, fechaNacimiento, dni, email, password);
                if (error == null)
                {
                    Supervisor supervisor = new Supervisor(nombre, apellido, fechaNacimiento, dni, email, password, -1, -1);
                    if (Conexion.AgregarSupervisor(supervisor))
                    {
                        Sistema.ListaDeUsuarios.Add(supervisor);
                        MessageBox.Show("Usuario Supervisor creado correctamente.");
                        Close();
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
                LogErrores.RegistrarError(ex.Message, typeof(FormCrearSupervisor).Name, nameof(btnCrearUsuario));
            }
        }

        private void btnLimpiarDatosCrearUsuario_Click(object sender, EventArgs e)
        {
            txtApellidoCrearUsuario.Text = string.Empty;
            txtNombreCrearUsuario.Text = string.Empty;
            txtPasswordCrearUsuario.Text = string.Empty;
            txtEmailCrearUsuario.Text = string.Empty;
            txtDniCrearUsuario.Text = string.Empty;
            dateFechaNacimientoCrearUsuario.SetDate(DateTime.Now);
        }
    }
}
