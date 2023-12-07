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

namespace CanepaJoaquinParcial
{
    public partial class FormListaUsuarioscs : Form
    {
        public FormListaUsuarioscs()
        {
            InitializeComponent();
            dataGridViewListaUsuarios.CellClick += dataGridViewListaUsuarios_CellClick;
        }

        private void Btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewListaUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = dataGridViewListaUsuarios.SelectedRows[0].Index;
                // Obtener el objeto Usuario correspondiente a la fila seleccionada
                Usuario usuario = (Usuario)dataGridViewListaUsuarios.Rows[indiceSeleccionado].DataBoundItem;

                if (usuario is Operario operario)
                {
                    bool eliminadoOperario = Conexion.BorrarOperario(operario.IdOperario);
                    if (eliminadoOperario)
                    {

                        MessageBox.Show("Operario eliminado correctamente.");

                        // Actualiz0 DataGridView
                        dataGridViewListaUsuarios.DataSource = null;
                        dataGridViewListaUsuarios.DataSource = Conexion.Leer();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Operario.");
                    }
                }
                else if (usuario is Supervisor supervisor)
                {
                    bool eliminadoSupervisor = Conexion.BorrarSupervisor(supervisor.SupervisorId);
                    if (eliminadoSupervisor)
                    {
                        MessageBox.Show("Supervisor eliminado correctamente.");
                        dataGridViewListaUsuarios.DataSource = null;
                        dataGridViewListaUsuarios.DataSource = Conexion.Leer();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Supervisor.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario a eliminar.");
            }
        }

        private void FormListaUsuarioscs_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de usuarios desde la base de datos
                List<Usuario> usuarios = Conexion.Leer();
                // Configurar el origen de datos del DataGridView
                dataGridViewListaUsuarios.DataSource = usuarios;
                dataGridViewListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewListaUsuarios.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los usuarios: " + ex.Message);
            }
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = (List<Usuario>)dataGridViewListaUsuarios.DataSource;
                SerializadorXml<List<Usuario>> serializador = new SerializadorXml<List<Usuario>>("usuariosSerializados.xml");

                if (serializador.Serializar(usuarios))
                {
                    MessageBox.Show("Serializado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al serializar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al serializar los usuarios: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btn_OrdenarAscendente_Click(object sender, EventArgs e)
        {
            // Obtengo la lista de usuarios desde el DataGridView
            List<Usuario> usuarios = (List<Usuario>)dataGridViewListaUsuarios.DataSource;
            Sistema.OrdenarDeManeraAscendente(usuarios, (a, b) => string.Compare(((dynamic)a).Apellido.ToString(), ((dynamic)b).Apellido.ToString()));
            // Actualizo
            dataGridViewListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaUsuarios.DataSource = null;
            dataGridViewListaUsuarios.DataSource = usuarios;
            dataGridViewListaUsuarios.Columns["Password"].Visible = false;
        }

        private void btn_ordenarDescendente_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = (List<Usuario>)dataGridViewListaUsuarios.DataSource;
            Sistema.OrdenarDeManeraDescendente(usuarios, (a, b) => string.Compare(((dynamic)a).Apellido.ToString(), ((dynamic)b).Apellido.ToString()));
            dataGridViewListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaUsuarios.DataSource = null;
            dataGridViewListaUsuarios.DataSource = usuarios;
            dataGridViewListaUsuarios.Columns["Password"].Visible = false;
        }

        private void dataGridViewListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Desmarcar todas las filas previamente seleccionadas
                foreach (DataGridViewRow row in dataGridViewListaUsuarios.Rows)
                {
                    row.Selected = false;
                }
                // Marco la fila en la que se hizo clic
                dataGridViewListaUsuarios.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
