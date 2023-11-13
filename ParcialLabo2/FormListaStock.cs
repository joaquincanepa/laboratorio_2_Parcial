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
           
        }
    }
}
