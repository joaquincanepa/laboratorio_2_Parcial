namespace CanepaJoaquinParcial
{
    partial class FormListaStock
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
            dataGridStock = new DataGridView();
            pnl_stock = new Panel();
            btn_serializarStock = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
            pnl_stock.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStock
            // 
            dataGridStock.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Dock = DockStyle.Fill;
            dataGridStock.Location = new Point(0, 0);
            dataGridStock.Name = "dataGridStock";
            dataGridStock.RowTemplate.Height = 25;
            dataGridStock.Size = new Size(818, 313);
            dataGridStock.TabIndex = 0;
            dataGridStock.CellClick += dataGridStock_CellClick;
            // 
            // pnl_stock
            // 
            pnl_stock.Controls.Add(dataGridStock);
            pnl_stock.Dock = DockStyle.Top;
            pnl_stock.Location = new Point(0, 0);
            pnl_stock.Name = "pnl_stock";
            pnl_stock.Size = new Size(818, 313);
            pnl_stock.TabIndex = 1;
            // 
            // btn_serializarStock
            // 
            btn_serializarStock.BackColor = SystemColors.WindowText;
            btn_serializarStock.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_serializarStock.ForeColor = Color.WhiteSmoke;
            btn_serializarStock.Location = new Point(266, 447);
            btn_serializarStock.Name = "btn_serializarStock";
            btn_serializarStock.Size = new Size(281, 49);
            btn_serializarStock.TabIndex = 2;
            btn_serializarStock.Text = "Serializar Stock";
            btn_serializarStock.UseVisualStyleBackColor = false;
            btn_serializarStock.Click += btn_serializarStock_Click;
            // 
            // FormListaStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(818, 622);
            Controls.Add(btn_serializarStock);
            Controls.Add(pnl_stock);
            MaximumSize = new Size(834, 661);
            MinimumSize = new Size(834, 661);
            Name = "FormListaStock";
            Text = "FormListaStock";
            Load += FormListaStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
            pnl_stock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridStock;
        private Panel pnl_stock;
        private Button btn_serializarStock;
    }
}