namespace ParcialLabo2
{
    partial class FormCrearSkate
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
            dataGridStockCrearSkate = new DataGridView();
            Material = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            pnl_FondoCrearSkate = new Panel();
            btnCrearSkate = new Button();
            btn_Ensamblado = new Button();
            pnl_ContenedorDataGridSkate = new Panel();
            dataGridViewListaSkate = new DataGridView();
            CantidadDeSkatesCreados = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridViewEnsamblado = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            NumeroSerie = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            CantidadEnsamblados = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridStockCrearSkate).BeginInit();
            pnl_FondoCrearSkate.SuspendLayout();
            pnl_ContenedorDataGridSkate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaSkate).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnsamblado).BeginInit();
            SuspendLayout();
            // 
            // dataGridStockCrearSkate
            // 
            dataGridStockCrearSkate.AllowUserToAddRows = false;
            dataGridStockCrearSkate.AllowUserToDeleteRows = false;
            dataGridStockCrearSkate.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridStockCrearSkate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStockCrearSkate.Columns.AddRange(new DataGridViewColumn[] { Material, Cantidad });
            dataGridStockCrearSkate.Dock = DockStyle.Fill;
            dataGridStockCrearSkate.Enabled = false;
            dataGridStockCrearSkate.Location = new Point(0, 0);
            dataGridStockCrearSkate.Name = "dataGridStockCrearSkate";
            dataGridStockCrearSkate.ReadOnly = true;
            dataGridStockCrearSkate.RowTemplate.Height = 25;
            dataGridStockCrearSkate.Size = new Size(668, 109);
            dataGridStockCrearSkate.TabIndex = 1;
            dataGridStockCrearSkate.CellContentClick += dataGridStockCrearSkate_CellContentClick;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.Name = "Material";
            Material.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // pnl_FondoCrearSkate
            // 
            pnl_FondoCrearSkate.Controls.Add(dataGridStockCrearSkate);
            pnl_FondoCrearSkate.Dock = DockStyle.Top;
            pnl_FondoCrearSkate.Location = new Point(0, 0);
            pnl_FondoCrearSkate.Name = "pnl_FondoCrearSkate";
            pnl_FondoCrearSkate.Size = new Size(668, 109);
            pnl_FondoCrearSkate.TabIndex = 2;
            // 
            // btnCrearSkate
            // 
            btnCrearSkate.Anchor = AnchorStyles.None;
            btnCrearSkate.AutoSize = true;
            btnCrearSkate.BackColor = SystemColors.WindowText;
            btnCrearSkate.FlatAppearance.BorderSize = 0;
            btnCrearSkate.FlatStyle = FlatStyle.Flat;
            btnCrearSkate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearSkate.ForeColor = Color.White;
            btnCrearSkate.Location = new Point(43, 400);
            btnCrearSkate.Name = "btnCrearSkate";
            btnCrearSkate.Padding = new Padding(10, 0, 0, 0);
            btnCrearSkate.Size = new Size(227, 54);
            btnCrearSkate.TabIndex = 6;
            btnCrearSkate.Text = "Crear Skate";
            btnCrearSkate.UseVisualStyleBackColor = false;
            btnCrearSkate.Click += btnCrearSkate_Click;
            // 
            // btn_Ensamblado
            // 
            btn_Ensamblado.Anchor = AnchorStyles.None;
            btn_Ensamblado.AutoSize = true;
            btn_Ensamblado.BackColor = SystemColors.WindowText;
            btn_Ensamblado.FlatAppearance.BorderSize = 0;
            btn_Ensamblado.FlatStyle = FlatStyle.Flat;
            btn_Ensamblado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ensamblado.ForeColor = Color.White;
            btn_Ensamblado.Location = new Point(340, 400);
            btn_Ensamblado.Name = "btn_Ensamblado";
            btn_Ensamblado.Padding = new Padding(10, 0, 0, 0);
            btn_Ensamblado.Size = new Size(243, 54);
            btn_Ensamblado.TabIndex = 7;
            btn_Ensamblado.Text = "Proceso de Ensamblado";
            btn_Ensamblado.UseVisualStyleBackColor = false;
            btn_Ensamblado.Click += btn_Ensamblado_Click;
            // 
            // pnl_ContenedorDataGridSkate
            // 
            pnl_ContenedorDataGridSkate.BackColor = Color.White;
            pnl_ContenedorDataGridSkate.Controls.Add(dataGridViewListaSkate);
            pnl_ContenedorDataGridSkate.Dock = DockStyle.Top;
            pnl_ContenedorDataGridSkate.Location = new Point(0, 109);
            pnl_ContenedorDataGridSkate.Name = "pnl_ContenedorDataGridSkate";
            pnl_ContenedorDataGridSkate.Size = new Size(668, 111);
            pnl_ContenedorDataGridSkate.TabIndex = 8;
            // 
            // dataGridViewListaSkate
            // 
            dataGridViewListaSkate.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewListaSkate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewListaSkate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaSkate.Columns.AddRange(new DataGridViewColumn[] { CantidadDeSkatesCreados, Total });
            dataGridViewListaSkate.Dock = DockStyle.Fill;
            dataGridViewListaSkate.Enabled = false;
            dataGridViewListaSkate.Location = new Point(0, 0);
            dataGridViewListaSkate.Name = "dataGridViewListaSkate";
            dataGridViewListaSkate.RowTemplate.Height = 25;
            dataGridViewListaSkate.Size = new Size(668, 111);
            dataGridViewListaSkate.TabIndex = 0;
            // 
            // CantidadDeSkatesCreados
            // 
            CantidadDeSkatesCreados.HeaderText = "cantidad de skates Listos para ensamblar";
            CantidadDeSkatesCreados.Name = "CantidadDeSkatesCreados";
            CantidadDeSkatesCreados.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(dataGridViewEnsamblado);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 114);
            panel2.TabIndex = 9;
            // 
            // dataGridViewEnsamblado
            // 
            dataGridViewEnsamblado.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewEnsamblado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnsamblado.Columns.AddRange(new DataGridViewColumn[] { Fecha, NumeroSerie, Modelo, CantidadEnsamblados });
            dataGridViewEnsamblado.Dock = DockStyle.Fill;
            dataGridViewEnsamblado.Enabled = false;
            dataGridViewEnsamblado.Location = new Point(0, 0);
            dataGridViewEnsamblado.Name = "dataGridViewEnsamblado";
            dataGridViewEnsamblado.RowTemplate.Height = 25;
            dataGridViewEnsamblado.Size = new Size(668, 114);
            dataGridViewEnsamblado.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // NumeroSerie
            // 
            NumeroSerie.HeaderText = "Numero de Serie";
            NumeroSerie.Name = "NumeroSerie";
            NumeroSerie.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // CantidadEnsamblados
            // 
            CantidadEnsamblados.HeaderText = "Cantidad Total de Ensamblados";
            CantidadEnsamblados.Name = "CantidadEnsamblados";
            CantidadEnsamblados.ReadOnly = true;
            // 
            // FormCrearSkate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(668, 522);
            Controls.Add(panel2);
            Controls.Add(pnl_ContenedorDataGridSkate);
            Controls.Add(btn_Ensamblado);
            Controls.Add(btnCrearSkate);
            Controls.Add(pnl_FondoCrearSkate);
            MaximumSize = new Size(684, 561);
            MinimumSize = new Size(684, 561);
            Name = "FormCrearSkate";
            Text = "FormCrearSkate";
            ((System.ComponentModel.ISupportInitialize)dataGridStockCrearSkate).EndInit();
            pnl_FondoCrearSkate.ResumeLayout(false);
            pnl_ContenedorDataGridSkate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaSkate).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnsamblado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridStockCrearSkate;
        private Panel pnl_FondoCrearSkate;
        private Button btnCrearSkate;
        private Button btn_Ensamblado;
        private Panel pnl_ContenedorDataGridSkate;
        private DataGridView dataGridViewListaSkate;
        private Panel panel2;
        private DataGridView dataGridViewEnsamblado;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn NumeroSerie;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn CantidadEnsamblados;
        private DataGridViewTextBoxColumn CantidadDeSkatesCreados;
        private DataGridViewTextBoxColumn Total;
    }
}