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
    public partial class FormListaUsuarioscs : Form
    {
        public FormListaUsuarioscs()
        {
            InitializeComponent();
            dataGridViewListaUsuarios.Rows.Clear();
            dataGridViewListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var usuarios in Sistema.ListaDeUsuarios)
            {
                dataGridViewListaUsuarios.Rows.Add(usuarios.Nombre, usuarios.Apellido, usuarios.FechaNacimiento, usuarios.Dni, usuarios.Email);
            }

        }
    }
}
