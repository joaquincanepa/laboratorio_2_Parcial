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
    public partial class FrmReponerStock : Form
    {
        ControlStock controlStock = null;
        public FrmReponerStock()
        {
            InitializeComponent();
            controlStock = ControlStock.GetInstance(); // Obtener la instancia existente

            dataGrid_Stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void FrmReponerStock_Load(object sender, EventArgs e)
        {

            dataGrid_Stock.Columns.Add("Material", "Material");
            dataGrid_Stock.Columns.Add("Cantidad", "Cantidad");
            foreach (var kvp in controlStock.StockMateriaPrima)
            {
                dataGrid_Stock.Rows.Add(kvp.Key, kvp.Value);
            }

        }

        private void btn_AgregarMadera_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Madera.Value;
            Sistema.AgregarMaterial("Madera", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Madera");

        }

        private void btn_AgregarTornillos_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Tornillos.Value;
            Sistema.AgregarMaterial("Tornillos", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Tornillos");
        }

        private void btn_AgregarRuedas_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Ruedas.Value;
            Sistema.AgregarMaterial("Ruedas", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Ruedas");
        }

        private void btnAgregarTrucks_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUDTrucks.Value;
            Sistema.AgregarMaterial("Trucks", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Trucks");

        }


        private void btn_AgregarCierre_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Cierre.Value;
            Sistema.AgregarMaterial("Cierre", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Cierre");

        }
        private void ActualizarCantidadMaterialEnDataGrid(string material)
        {
            foreach (DataGridViewRow row in dataGrid_Stock.Rows)
            {
                if (row.Cells[0].Value.ToString() == material)
                {
                    row.Cells[1].Value = Sistema.ObtenerCantidadMaterial(material);
                    break;
                }
            }
        }



        private void btn_AgregarCuchilla_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Cuchilla.Value;
            Sistema.AgregarMaterial("Cuchilla", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Cuchilla");
        }

        private void btn_AgregarBotasPlastico_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_BotasPlastico.Value;
            Sistema.AgregarMaterial("BotasDePlastico", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("BotasDePlastico");

        }

        private void btn_AgregarBotaDeCuero_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_BotaDeCuero.Value;
            Sistema.AgregarMaterial("BotaDeCuero", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("BotaDeCuero");
        }

        private void btnAgregarAluminio_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Aluminio.Value;
            Sistema.AgregarMaterial("Aluminio", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Aluminio");
        }

        private void btn_AgregarTacoDelantero_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_TacoDelantero.Value;
            Sistema.AgregarMaterial("TacoDelantero", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("TacoDelantero");
        }

        private void btn_AgreagrCordones_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_Cordones.Value;
            Sistema.AgregarMaterial("Cordones", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("Cordones");
        }

        private void btn_AgregarFibraDeCarbono_Click(object sender, EventArgs e)
        {
            int cantidadAgregada = (int)NUD_FibraDeCarbono.Value;
            Sistema.AgregarMaterial("FibraDeCarbono", cantidadAgregada);
            ActualizarCantidadMaterialEnDataGrid("FibraDeCarbono");
        }
    }
}
