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
    public partial class FormCrearRollers : Form
    {
        private ControlStock controlStock;
        private string tipoSeleccionadoParaEmpaquetar;
        public FormCrearRollers()
        {
            InitializeComponent();
            controlStock = ControlStock.GetInstance();
            MostrarStockEnDataGridView();
            ActualizarDataGridView();
            dataGridStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRollers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCrearRoller_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericUpDownCantidad.Value;
            if (rdoPatinArtistico.Checked || rdoPatinFreeStyle.Checked || rdoPatinSobreHielo.Checked)
            {
                if (cantidad > 0)
                {
                    Roller.TipoDeRoller tipo;

                    if (rdoPatinFreeStyle.Checked)
                    {
                        tipo = Roller.TipoDeRoller.PatinFreeStyle;
                    }
                    else if (rdoPatinSobreHielo.Checked)
                    {
                        tipo = Roller.TipoDeRoller.PatinSobreHielo;
                    }
                    else
                    {
                        tipo = Roller.TipoDeRoller.PatinArtistico;
                    }

                    if (Sistema.CrearRollers(tipo, cantidad))
                    {

                        ActualizarDataGridView();
                        MostrarStockEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente material en stock para crear los Rollers.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, elija un tipo de Roller.");
            }
        }
        private void ActualizarDataGridView()
        {
            dataGridViewRollers.DataSource = null;
            dataGridViewRollers.DataSource = Sistema.ListaDeRoller;
        }

        private void MostrarStockEnDataGridView()
        {
            dataGridStock.Rows.Clear();

            foreach (var kvp in controlStock.StockMateriaPrima)
            {
                dataGridStock.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void btn_Empaquetar_Click(object sender, EventArgs e)
        {
            if (Sistema.EmpaquetarRoller(tipoSeleccionadoParaEmpaquetar))
            {
                MessageBox.Show("El roller ha sido empaquetado y agregado al inventario.");
                MostrarRollersEmpaquetadosEnDataGridView();
                ActualizarDataGridView();

            }
            else
            {
                MessageBox.Show("No tienes un Roller construido para Empaquetar.");
            }

        }


        private void MostrarRollersEmpaquetadosEnDataGridView()
        {
            dataGridViewEmpaquetado.Rows.Clear();

            foreach (var rollerEmpaquetado in Sistema.listaDeRollerEmpaquetados)
            {
                dataGridViewEmpaquetado.Rows.Add(rollerEmpaquetado.FechaDefabricacion, rollerEmpaquetado.NumeroSerie1, rollerEmpaquetado.Modelo, rollerEmpaquetado.NombreDelOperario);
            }

            // Agrega una fila al final
            dataGridViewEmpaquetado.Rows.Add("", "", "Cantidad Total de roller Empaquetado:", Sistema.listaDeRollerEmpaquetados.Count);
        }


        private void rdoEmpaquetarArtistico_CheckedChanged(object sender, EventArgs e)
        {
            tipoSeleccionadoParaEmpaquetar = "PatinArtistico";
        }

        private void rdoEmpaquetarFreeStyle_CheckedChanged(object sender, EventArgs e)
        {
            tipoSeleccionadoParaEmpaquetar = "PatinFreeStyle";
        }

        private void rdoEmpaquetarSobreHielo_CheckedChanged(object sender, EventArgs e)
        {
            tipoSeleccionadoParaEmpaquetar = "PatinSobreHielo";
        }
    }
}
