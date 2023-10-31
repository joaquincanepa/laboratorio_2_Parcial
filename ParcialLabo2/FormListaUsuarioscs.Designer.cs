namespace CanepaJoaquinParcial
{
    partial class FormListaUsuarioscs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewListaUsuarios = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Fecha_nacimiento = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaUsuarios
            // 
            dataGridViewListaUsuarios.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Fecha_nacimiento, DNI, Email });
            dataGridViewListaUsuarios.Dock = DockStyle.Fill;
            dataGridViewListaUsuarios.Location = new Point(0, 0);
            dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            dataGridViewListaUsuarios.RowTemplate.Height = 25;
            dataGridViewListaUsuarios.Size = new Size(800, 450);
            dataGridViewListaUsuarios.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            Fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            Fecha_nacimiento.Name = "Fecha_nacimiento";
            Fecha_nacimiento.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // FormListaUsuarioscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewListaUsuarios);
            Name = "FormListaUsuarioscs";
            Text = "FormListaUsuarioscs";
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewListaUsuarios;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Email;
    }
}