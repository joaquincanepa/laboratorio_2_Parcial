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
            pnl_usuarios = new Panel();
            dataGridViewListaUsuarios = new DataGridView();
            Btn_EliminarUsuario = new Button();
            btnSerializar = new Button();
            btn_OrdenarAscendente = new Button();
            btn_ordenarDescendente = new Button();
            pnl_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnl_usuarios
            // 
            pnl_usuarios.Controls.Add(dataGridViewListaUsuarios);
            pnl_usuarios.Dock = DockStyle.Top;
            pnl_usuarios.Location = new Point(0, 0);
            pnl_usuarios.Name = "pnl_usuarios";
            pnl_usuarios.Size = new Size(818, 392);
            pnl_usuarios.TabIndex = 1;
            // 
            // dataGridViewListaUsuarios
            // 
            dataGridViewListaUsuarios.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaUsuarios.Dock = DockStyle.Fill;
            dataGridViewListaUsuarios.Location = new Point(0, 0);
            dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            dataGridViewListaUsuarios.RowTemplate.Height = 25;
            dataGridViewListaUsuarios.Size = new Size(818, 392);
            dataGridViewListaUsuarios.TabIndex = 1;
            dataGridViewListaUsuarios.CellClick += dataGridViewListaUsuarios_CellClick;
            // 
            // Btn_EliminarUsuario
            // 
            Btn_EliminarUsuario.BackColor = SystemColors.WindowText;
            Btn_EliminarUsuario.FlatStyle = FlatStyle.Flat;
            Btn_EliminarUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_EliminarUsuario.ForeColor = Color.WhiteSmoke;
            Btn_EliminarUsuario.Location = new Point(535, 414);
            Btn_EliminarUsuario.Name = "Btn_EliminarUsuario";
            Btn_EliminarUsuario.Size = new Size(183, 63);
            Btn_EliminarUsuario.TabIndex = 2;
            Btn_EliminarUsuario.Text = "Eliminar Usuario";
            Btn_EliminarUsuario.UseVisualStyleBackColor = false;
            Btn_EliminarUsuario.Click += Btn_EliminarUsuario_Click;
            // 
            // btnSerializar
            // 
            btnSerializar.BackColor = SystemColors.WindowText;
            btnSerializar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializar.ForeColor = Color.WhiteSmoke;
            btnSerializar.Location = new Point(535, 496);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(183, 74);
            btnSerializar.TabIndex = 3;
            btnSerializar.Text = "Serializar Usuarios";
            btnSerializar.UseVisualStyleBackColor = false;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btn_OrdenarAscendente
            // 
            btn_OrdenarAscendente.BackColor = SystemColors.WindowText;
            btn_OrdenarAscendente.FlatStyle = FlatStyle.Flat;
            btn_OrdenarAscendente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OrdenarAscendente.ForeColor = Color.WhiteSmoke;
            btn_OrdenarAscendente.Location = new Point(41, 431);
            btn_OrdenarAscendente.Name = "btn_OrdenarAscendente";
            btn_OrdenarAscendente.Size = new Size(252, 46);
            btn_OrdenarAscendente.TabIndex = 4;
            btn_OrdenarAscendente.Text = "Ordenar Ascendente";
            btn_OrdenarAscendente.UseVisualStyleBackColor = false;
            btn_OrdenarAscendente.Click += btn_OrdenarAscendente_Click;
            // 
            // btn_ordenarDescendente
            // 
            btn_ordenarDescendente.BackColor = SystemColors.WindowText;
            btn_ordenarDescendente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ordenarDescendente.ForeColor = Color.WhiteSmoke;
            btn_ordenarDescendente.Location = new Point(41, 524);
            btn_ordenarDescendente.Name = "btn_ordenarDescendente";
            btn_ordenarDescendente.Size = new Size(252, 46);
            btn_ordenarDescendente.TabIndex = 5;
            btn_ordenarDescendente.Text = "Ordenar Descendiente";
            btn_ordenarDescendente.UseVisualStyleBackColor = false;
            btn_ordenarDescendente.Click += btn_ordenarDescendente_Click;
            // 
            // FormListaUsuarioscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(818, 622);
            Controls.Add(btn_ordenarDescendente);
            Controls.Add(btn_OrdenarAscendente);
            Controls.Add(btnSerializar);
            Controls.Add(Btn_EliminarUsuario);
            Controls.Add(pnl_usuarios);
            MaximumSize = new Size(834, 661);
            MinimumSize = new Size(834, 661);
            Name = "FormListaUsuarioscs";
            Text = "FormListaUsuarioscs";
            Load += FormListaUsuarioscs_Load;
            pnl_usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_usuarios;
        private Button Btn_EliminarUsuario;
        private DataGridView dataGridViewListaUsuarios;
        private Button btnSerializar;
        private Button btn_OrdenarAscendente;
        private Button btn_ordenarDescendente;
    }
}