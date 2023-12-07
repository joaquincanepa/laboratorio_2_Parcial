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
    public partial class FormCrearSkate : Form
    {
        private ControlStock controlStock;
        private bool salioDelForm;
        public FormCrearSkate()
        {
            InitializeComponent();
            controlStock = ControlStock.GetInstance();
            controlStock.CargarStockDesdeXml();
            MostrarStockEnDataGridView();
            MostrarSkatesEnsambladosEnDataGridView();
            MostrarSkatesEnDataGridView();
            dataGridStockCrearSkate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//acomodo las columnas
            dataGridViewEnsamblado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaSkate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCrearSkate_Click(object sender, EventArgs e)
        {
            if (Sistema.CrearSkate())
            {
                MostrarStockEnDataGridView();
                MostrarSkatesEnDataGridView();
                MessageBox.Show("Se ha creado un nuevo skate.");
            }
            else
            {
                MessageBox.Show("No hay suficiente material en stock para crear un skate.");
            }
        }

        /// <summary>
        /// Ensambla un skate de forma asíncrona.
        /// </summary>
        /// <returns>Una tarea que representa la operación de ensamblaje.</returns>
        private async Task EnsamblarSkate()
        {
            await Task.Delay(3000);
            Eventos.Invoke("Skate", 1);

        }

        private async void btn_Ensamblado_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sistema.EnsamblarSkate())
                {

                    await EnsamblarSkate();
                    MessageBox.Show("El skate ha sido ensamblado y agregado al inventario.");
                    if (salioDelForm == false)
                    {
                        MostrarSkatesEnsambladosEnDataGridView();
                        MostrarSkatesEnDataGridView();
                    }
                }
                else
                {
                    throw new NoExisteParaEmpaquetarOEnsamblar("No tienes un skate construido para ensamblar.");
                }
            }
            catch (NoExisteParaEmpaquetarOEnsamblar ex)
            {
                MessageBox.Show($"Error al intentar ensamblar el skate: {ex.Message}", "Error de Ensamblaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogErrores.RegistrarError(ex.Message, typeof(FormCrearSkate).Name, nameof(btn_Ensamblado));
            }

        }


        /// <summary>
        /// Muestra el stock en un DataGridView.
        /// </summary>
        private void MostrarStockEnDataGridView()
        {
            dataGridStockCrearSkate.Rows.Clear();

            foreach (var kvp in controlStock.StockMateriaPrima)
            {
                dataGridStockCrearSkate.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        /// <summary>
        /// Muestra la cantidad total de skates listos para ensamblar en el DataGridView.
        /// </summary>
        private void MostrarSkatesEnDataGridView()
        {
            dataGridViewListaSkate.Rows.Clear();
            dataGridViewListaSkate.Rows.Add("Cantidad Total de Skates Listos para ensamblar:", Sistema.ListaDeSkate.Count);
        }

        /// <summary>
        /// Muestra los skates ensamblados en un DataGridView, incluyendo la cantidad total de skates ensamblados.
        /// </summary>
        private void MostrarSkatesEnsambladosEnDataGridView()
        {
            if (dataGridViewEnsamblado != null)
            {
                dataGridViewEnsamblado.Rows.Clear();

                foreach (var skateEnsamblado in Sistema.listaDeSkateEnsamblados)
                {
                    dataGridViewEnsamblado.Rows.Add(skateEnsamblado.FechaFabricacion, skateEnsamblado.NumeroSerie, skateEnsamblado.Modelo);
                }
                dataGridViewEnsamblado.Rows.Add("", "", "Cantidad Total de Skates Ensamblados:", Sistema.listaDeSkateEnsamblados.Count);
            }

        }

        private void dataGridStockCrearSkate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridStockCrearSkate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Acomodo las columnasd
        }

        private void FormCrearSkate_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            salioDelForm = true;
        }
    }
}
