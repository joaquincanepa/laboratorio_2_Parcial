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

namespace CanepaJoaquinParcial
{
    public partial class FormListaStock : Form
    {
        ControlStock controlStock = null;
        public FormListaStock()
        {
            InitializeComponent();
            controlStock = ControlStock.GetInstance(); // obtengo la instancia
            dataGridStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStock.CellClick += dataGridStock_CellClick;
        }

        private void FormListaStock_Load(object sender, EventArgs e)
        {
            dataGridStock.Columns.Add("Material", "Material");
            dataGridStock.Columns.Add("Cantidad", "Cantidad");
            foreach (var kvp in controlStock.StockMateriaPrima)
            {
                dataGridStock.Rows.Add(kvp.Key, kvp.Value);
            }

        }

        private void btn_serializarStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Llenar la información actual del controlStock
                controlStock.SerializableStock.StockMateriaPrima = controlStock.StockMateriaPrima
                    .Select(item => new StockItem { Material = item.Key, Cantidad = item.Value })
                    .ToList();

                SerializadorXml<SerializableStock> serializador = new SerializadorXml<SerializableStock>("controlStock.xml");
                if (serializador.Serializar(controlStock.SerializableStock))
                {
                    MessageBox.Show("ControlStock serializado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al serializar ControlStock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al serializar ControlStock: " + ex.Message);
            }
        }

        private void dataGridStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Desmarcar todas las filas previamente seleccionadas
                foreach (DataGridViewRow row in dataGridStock.Rows)
                {
                    row.Selected = false;
                }
                // Marcar toda la fila en la que se hizo clic
                dataGridStock.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
