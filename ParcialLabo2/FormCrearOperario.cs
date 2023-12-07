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
        private CancellationTokenSource cancellationTokenSource;
        private bool isCancelled = false;
        public FormCrearOperario()
        {
            InitializeComponent();
        }

        private async void btnCrearUsuarioOperario_Click(object sender, EventArgs e)
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
                    cancellationTokenSource = new CancellationTokenSource();
                    IProgress<int> progress = new Progress<int>(value =>
                    {
                        // Actualizar la barra de progreso
                        progressBar1.Value = value;
                    });

                    try
                    {
                        btnLimpiarDatosCrearUsuario.Enabled = false;
                        await SubirUsuarioAsync(progress, cancellationTokenSource.Token, nombre, apellido, fechaNacimiento, dni, email, password);

                        if (!isCancelled)
                        {
                            Operario operario = new Operario(nombre, apellido, fechaNacimiento, dni, email, password, -1, -1);
                            if (Conexion.AgregarOperario(operario))
                            {
                                MessageBox.Show("Operación completada.");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el operario");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                    finally{ 
                        btnLimpiarDatosCrearUsuario.Enabled = true;
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
                LogErrores.RegistrarError(ex.Message, typeof(FormCrearOperario).Name, nameof(btnCrearUsuarioOperario));
            }
        }

        /// <summary>
        /// Realiza la subida simulada de un usuario a través de una operación asíncrona.
        /// </summary>
        /// <param name="progress">Objeto que implementa la interfaz IProgress&lt;int&gt; para informar sobre el progreso.</param>
        /// <param name="cancellationToken">Token de cancelación que permite solicitar la cancelación de la operación.</param>
        /// <param name="nombre">Nombre del usuario a subir.</param>
        /// <param name="apellido">Apellido del usuario a subir.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del usuario a subir.</param>
        /// <param name="dni">Número de documento del usuario a subir.</param>
        /// <param name="email">Dirección de correo electrónico del usuario a subir.</param>
        /// <param name="password">Contraseña del usuario a subir.</param>
        /// <returns>Una tarea que representa la operación asíncrona.</returns>
        private async Task SubirUsuarioAsync(IProgress<int> progress, CancellationToken cancellationToken, string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password)
        {
            await Task.Run(() =>
            {
                // Operación de subida del usuario
                for (int i = 0; i <= 100; i++)
                {
                    // Verificar si se ha solicitado la cancelación
                    if (cancellationToken.IsCancellationRequested)
                    {
                        isCancelled = true;
                        return;
                    }

                    // Simular la subida del usuario
                    Thread.Sleep(100); // Simula una operación de carga
                    progress.Report(i); // Actualiza la barra de progreso
                }

            }, cancellationToken);
        }

        private void btnLimpiarDatosCrearUsuario_Click(object sender, EventArgs e)
        {

            LimpiarDatos();

        }

        private void LimpiarDatos()
        {
            progressBar1.Value = 0;
            txtApellidoCrearUsuario.Text = string.Empty;
            txtNombreCrearUsuario.Text = string.Empty;
            txtPasswordCrearUsuario.Text = string.Empty;
            txtEmailCrearUsuario.Text = string.Empty;
            txtDniCrearUsuario.Text = string.Empty;
            dateDechaNacimientoCrearUsuarioOperario.SetDate(DateTime.Now);
            isCancelled = false;
        }

        private void FormCrearOperario_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            LimpiarDatos();
        }
    }
}
