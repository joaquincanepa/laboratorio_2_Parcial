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
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
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
            dataGridStock.Size = new Size(668, 522);
            dataGridStock.TabIndex = 0;
            // 
            // FormListaStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 522);
            Controls.Add(dataGridStock);
            MaximumSize = new Size(684, 561);
            MinimumSize = new Size(684, 561);
            Name = "FormListaStock";
            Text = "FormListaStock";
            Load += FormListaStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridStock;
    }
}