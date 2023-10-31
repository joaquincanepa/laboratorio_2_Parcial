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
        public FormCrearSkate()
        {
            InitializeComponent();
            controlStock = ControlStock.GetInstance();
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


        private void btn_Ensamblado_Click(object sender, EventArgs e)
        {
            if (Sistema.EnsamblarSkate())
            {
                MessageBox.Show("El skate ha sido ensamblado y agregado al inventario.");
                MostrarSkatesEnsambladosEnDataGridView();
                MostrarSkatesEnDataGridView();
            }
            else
            {
                MessageBox.Show("No tienes un skate construido para ensamblar.");
            }

        }

        private void MostrarStockEnDataGridView()
        {
            dataGridStockCrearSkate.Rows.Clear();

            foreach (var kvp in controlStock.StockMateriaPrima)
            {
                dataGridStockCrearSkate.Rows.Add(kvp.Key, kvp.Value);
            }
        }


        private void MostrarSkatesEnDataGridView()
        {
            dataGridViewListaSkate.Rows.Clear();
            dataGridViewListaSkate.Rows.Add("Cantidad Total de Skates Listos para ensamblar:", Sistema.ListaDeSkate.Count);
        }

        private void MostrarSkatesEnsambladosEnDataGridView()
        {

            dataGridViewEnsamblado.Rows.Clear();

            foreach (var skateEnsamblado in Sistema.listaDeSkateEnsamblados)
            {
                dataGridViewEnsamblado.Rows.Add(skateEnsamblado.FechaFabricacion, skateEnsamblado.NumeroSerie, skateEnsamblado.Modelo);
            }
            dataGridViewEnsamblado.Rows.Add("", "", "Cantidad Total de Skates Ensamblados:", Sistema.listaDeSkateEnsamblados.Count);
        }

        private void dataGridStockCrearSkate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridStockCrearSkate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Acomodo las columnasd
        }
    }
}
