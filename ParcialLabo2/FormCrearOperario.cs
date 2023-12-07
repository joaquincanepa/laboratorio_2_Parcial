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
        CancellationTokenSource cancellationTokenSource;
        public FormCrearOperario()
        {
            InitializeComponent();
        }

        private void IncrementarBarraProgreso(ProgressBar progressBar, Label label, int idHilo)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label, int> delegado = IncrementarBarraProgreso;
                object[] parametros = new object[] { progressBar, label, idHilo };
                Invoke(delegado, parametros);
            }
            else
            {
                label.Text = $"Hilo N°{idHilo} - {progressBar.Value}%";
                progressBar.Increment(1);
            }
        }

        private void FinalizarProceso(ProgressBar progressBar, Label label, Operario operario)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label, Operario> delegado = FinalizarProceso;
                object[] parametros = new object[] { progressBar, label, operario };
                Invoke(delegado, parametros);
            }
            else
            {
                if (progressBar.Value == progressBar.Maximum)
                {
                    label1.Text = "Finalizado";
                    Sistema.ListaDeUsuarios.Add(operario);
                    MessageBox.Show("Usuario Operario creado correctamente.");
                }
                else
                {
                    label1.Text = "Cancelado";
                }
            }
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
                    Operario operario = new Operario(nombre, apellido, fechaNacimiento, dni, email, password, -1, -1);
                    if (Conexion.AgregarOperario(operario))
                    {
                        await IniciarHiloAsync(operario);
                        MessageBox.Show("Operación completada.");
                        Close();  // Mover el cierre del formulario aquí
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
                LogErrores.RegistrarError(ex.Message, typeof(FormCrearOperario).Name, nameof(btnCrearUsuarioOperario));
            }
        }


        private async Task IniciarHiloAsync(Operario operario)
        {
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            try
            {
                await Task.Run(() => IniciarProceso(progressBar1, label1, operario, cancellationToken), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Manejar la cancelación aquí, si es necesario
                MessageBox.Show("Operación cancelada.");
            }
            finally
            {
                if (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    // Solo finalizar si la cancelación no ha sido solicitada
                    FinalizarProceso(progressBar1, label1, operario);
                }
                else
                {
                    // Si la cancelación fue solicitada, completar la tarea inmediatamente
                    cancellationTokenSource = null;
                }
            }
        }


        private void IniciarProceso(ProgressBar progressBar, Label label, Operario operario, CancellationToken cancellationToken)
        {
            try
            {
                while (progressBar.Value < progressBar.Maximum)
                {
                    cancellationToken.ThrowIfCancellationRequested(); // Check if cancellation is requested

                    Thread.Sleep(new Random().Next(100));

                    // Verificar nuevamente si la cancelación está solicitada antes de incrementar la barra de progreso
                    cancellationToken.ThrowIfCancellationRequested();

                    IncrementarBarraProgreso(progressBar, label, Task.CurrentId.Value);
                }

                // Verificar nuevamente si la cancelación está solicitada antes de agregar a la base de datos
                cancellationToken.ThrowIfCancellationRequested();

                // Solo se llegará aquí si la operación no ha sido cancelada
                FinalizarProceso(progressBar, label, operario);
            }
            catch (OperationCanceledException)
            {
                // Cancellation is requested
                MessageBox.Show("Operación cancelada.");
                // No llamar a FinalizarProceso aquí
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private void btnLimpiarDatosCrearUsuario_Click(object sender, EventArgs e)
        {

            txtApellidoCrearUsuario.Text = string.Empty;
            txtNombreCrearUsuario.Text = string.Empty;
            txtPasswordCrearUsuario.Text = string.Empty;
            txtEmailCrearUsuario.Text = string.Empty;
            txtDniCrearUsuario.Text = string.Empty;
            dateDechaNacimientoCrearUsuarioOperario.SetDate(DateTime.Now);

        }
    }
}
