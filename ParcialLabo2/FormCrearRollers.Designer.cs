namespace ParcialLabo2
{
    partial class FormCrearRollers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearRollers));
            btnCrearRoller = new Button();
            grpSeleccionCrear = new GroupBox();
            numericUpDownCantidad = new NumericUpDown();
            rdoPatinSobreHielo = new RadioButton();
            rdoPatinFreeStyle = new RadioButton();
            rdoPatinArtistico = new RadioButton();
            pnl_ContenedorDataGridSkate = new Panel();
            dataGridViewRollers = new DataGridView();
            pnl_FondoCrearSkate = new Panel();
            dataGridStock = new DataGridView();
            Material = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            btn_Empaquetar = new Button();
            dataGridViewEmpaquetado = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            NumeroSerie = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            ApellidoOperario = new DataGridViewTextBoxColumn();
            CantidadTotalDeEmpaquetado = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            rdoEmpaquetarSobreHielo = new RadioButton();
            rdoEmpaquetarFreeStyle = new RadioButton();
            rdoEmpaquetarArtistico = new RadioButton();
            grpSeleccionCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            pnl_ContenedorDataGridSkate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRollers).BeginInit();
            pnl_FondoCrearSkate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpaquetado).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearRoller
            // 
            resources.ApplyResources(btnCrearRoller, "btnCrearRoller");
            btnCrearRoller.BackColor = SystemColors.WindowText;
            btnCrearRoller.FlatAppearance.BorderSize = 0;
            btnCrearRoller.ForeColor = Color.White;
            btnCrearRoller.Name = "btnCrearRoller";
            btnCrearRoller.UseVisualStyleBackColor = false;
            btnCrearRoller.Click += btnCrearRoller_Click;
            // 
            // grpSeleccionCrear
            // 
            resources.ApplyResources(grpSeleccionCrear, "grpSeleccionCrear");
            grpSeleccionCrear.Controls.Add(numericUpDownCantidad);
            grpSeleccionCrear.Controls.Add(rdoPatinSobreHielo);
            grpSeleccionCrear.Controls.Add(rdoPatinFreeStyle);
            grpSeleccionCrear.Controls.Add(rdoPatinArtistico);
            grpSeleccionCrear.Controls.Add(btnCrearRoller);
            grpSeleccionCrear.ForeColor = SystemColors.ControlLight;
            grpSeleccionCrear.Name = "grpSeleccionCrear";
            grpSeleccionCrear.TabStop = false;
            // 
            // numericUpDownCantidad
            // 
            resources.ApplyResources(numericUpDownCantidad, "numericUpDownCantidad");
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rdoPatinSobreHielo
            // 
            resources.ApplyResources(rdoPatinSobreHielo, "rdoPatinSobreHielo");
            rdoPatinSobreHielo.ForeColor = Color.CornflowerBlue;
            rdoPatinSobreHielo.Name = "rdoPatinSobreHielo";
            rdoPatinSobreHielo.TabStop = true;
            rdoPatinSobreHielo.UseVisualStyleBackColor = true;
            // 
            // rdoPatinFreeStyle
            // 
            resources.ApplyResources(rdoPatinFreeStyle, "rdoPatinFreeStyle");
            rdoPatinFreeStyle.ForeColor = Color.CornflowerBlue;
            rdoPatinFreeStyle.Name = "rdoPatinFreeStyle";
            rdoPatinFreeStyle.TabStop = true;
            rdoPatinFreeStyle.UseVisualStyleBackColor = true;
            // 
            // rdoPatinArtistico
            // 
            resources.ApplyResources(rdoPatinArtistico, "rdoPatinArtistico");
            rdoPatinArtistico.ForeColor = Color.CornflowerBlue;
            rdoPatinArtistico.Name = "rdoPatinArtistico";
            rdoPatinArtistico.TabStop = true;
            rdoPatinArtistico.UseVisualStyleBackColor = true;
            // 
            // pnl_ContenedorDataGridSkate
            // 
            pnl_ContenedorDataGridSkate.BackColor = Color.White;
            pnl_ContenedorDataGridSkate.Controls.Add(dataGridViewRollers);
            resources.ApplyResources(pnl_ContenedorDataGridSkate, "pnl_ContenedorDataGridSkate");
            pnl_ContenedorDataGridSkate.Name = "pnl_ContenedorDataGridSkate";
            // 
            // dataGridViewRollers
            // 
            dataGridViewRollers.AllowUserToAddRows = false;
            dataGridViewRollers.AllowUserToDeleteRows = false;
            dataGridViewRollers.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewRollers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewRollers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewRollers, "dataGridViewRollers");
            dataGridViewRollers.Name = "dataGridViewRollers";
            dataGridViewRollers.ReadOnly = true;
            dataGridViewRollers.RowTemplate.Height = 25;
            // 
            // pnl_FondoCrearSkate
            // 
            pnl_FondoCrearSkate.Controls.Add(dataGridStock);
            resources.ApplyResources(pnl_FondoCrearSkate, "pnl_FondoCrearSkate");
            pnl_FondoCrearSkate.Name = "pnl_FondoCrearSkate";
            // 
            // dataGridStock
            // 
            dataGridStock.AllowUserToAddRows = false;
            dataGridStock.AllowUserToDeleteRows = false;
            dataGridStock.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Columns.AddRange(new DataGridViewColumn[] { Material, Cantidad });
            resources.ApplyResources(dataGridStock, "dataGridStock");
            dataGridStock.Name = "dataGridStock";
            dataGridStock.ReadOnly = true;
            dataGridStock.RowTemplate.Height = 25;
            // 
            // Material
            // 
            resources.ApplyResources(Material, "Material");
            Material.Name = "Material";
            Material.ReadOnly = true;
            // 
            // Cantidad
            // 
            resources.ApplyResources(Cantidad, "Cantidad");
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // btn_Empaquetar
            // 
            resources.ApplyResources(btn_Empaquetar, "btn_Empaquetar");
            btn_Empaquetar.BackColor = SystemColors.WindowText;
            btn_Empaquetar.FlatAppearance.BorderSize = 0;
            btn_Empaquetar.ForeColor = Color.White;
            btn_Empaquetar.Name = "btn_Empaquetar";
            btn_Empaquetar.UseVisualStyleBackColor = false;
            btn_Empaquetar.Click += btn_Empaquetar_Click;
            // 
            // dataGridViewEmpaquetado
            // 
            dataGridViewEmpaquetado.AllowUserToAddRows = false;
            dataGridViewEmpaquetado.AllowUserToDeleteRows = false;
            dataGridViewEmpaquetado.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridViewEmpaquetado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpaquetado.Columns.AddRange(new DataGridViewColumn[] { Fecha, NumeroSerie, Modelo, ApellidoOperario, CantidadTotalDeEmpaquetado });
            resources.ApplyResources(dataGridViewEmpaquetado, "dataGridViewEmpaquetado");
            dataGridViewEmpaquetado.Name = "dataGridViewEmpaquetado";
            dataGridViewEmpaquetado.ReadOnly = true;
            dataGridViewEmpaquetado.RowTemplate.Height = 25;
            // 
            // Fecha
            // 
            resources.ApplyResources(Fecha, "Fecha");
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // NumeroSerie
            // 
            resources.ApplyResources(NumeroSerie, "NumeroSerie");
            NumeroSerie.Name = "NumeroSerie";
            NumeroSerie.ReadOnly = true;
            // 
            // Modelo
            // 
            resources.ApplyResources(Modelo, "Modelo");
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // ApellidoOperario
            // 
            resources.ApplyResources(ApellidoOperario, "ApellidoOperario");
            ApellidoOperario.Name = "ApellidoOperario";
            ApellidoOperario.ReadOnly = true;
            // 
            // CantidadTotalDeEmpaquetado
            // 
            resources.ApplyResources(CantidadTotalDeEmpaquetado, "CantidadTotalDeEmpaquetado");
            CantidadTotalDeEmpaquetado.Name = "CantidadTotalDeEmpaquetado";
            CantidadTotalDeEmpaquetado.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(rdoEmpaquetarSobreHielo);
            groupBox1.Controls.Add(rdoEmpaquetarFreeStyle);
            groupBox1.Controls.Add(btn_Empaquetar);
            groupBox1.Controls.Add(rdoEmpaquetarArtistico);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // rdoEmpaquetarSobreHielo
            // 
            resources.ApplyResources(rdoEmpaquetarSobreHielo, "rdoEmpaquetarSobreHielo");
            rdoEmpaquetarSobreHielo.ForeColor = Color.CornflowerBlue;
            rdoEmpaquetarSobreHielo.Name = "rdoEmpaquetarSobreHielo";
            rdoEmpaquetarSobreHielo.TabStop = true;
            rdoEmpaquetarSobreHielo.UseVisualStyleBackColor = true;
            rdoEmpaquetarSobreHielo.CheckedChanged += rdoEmpaquetarSobreHielo_CheckedChanged;
            // 
            // rdoEmpaquetarFreeStyle
            // 
            resources.ApplyResources(rdoEmpaquetarFreeStyle, "rdoEmpaquetarFreeStyle");
            rdoEmpaquetarFreeStyle.ForeColor = Color.CornflowerBlue;
            rdoEmpaquetarFreeStyle.Name = "rdoEmpaquetarFreeStyle";
            rdoEmpaquetarFreeStyle.TabStop = true;
            rdoEmpaquetarFreeStyle.UseVisualStyleBackColor = true;
            rdoEmpaquetarFreeStyle.CheckedChanged += rdoEmpaquetarFreeStyle_CheckedChanged;
            // 
            // rdoEmpaquetarArtistico
            // 
            resources.ApplyResources(rdoEmpaquetarArtistico, "rdoEmpaquetarArtistico");
            rdoEmpaquetarArtistico.ForeColor = Color.CornflowerBlue;
            rdoEmpaquetarArtistico.Name = "rdoEmpaquetarArtistico";
            rdoEmpaquetarArtistico.TabStop = true;
            rdoEmpaquetarArtistico.UseVisualStyleBackColor = true;
            rdoEmpaquetarArtistico.CheckedChanged += rdoEmpaquetarArtistico_CheckedChanged;
            // 
            // FormCrearRollers
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewEmpaquetado);
            Controls.Add(pnl_ContenedorDataGridSkate);
            Controls.Add(pnl_FondoCrearSkate);
            Controls.Add(grpSeleccionCrear);
            Name = "FormCrearRollers";
            grpSeleccionCrear.ResumeLayout(false);
            grpSeleccionCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            pnl_ContenedorDataGridSkate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRollers).EndInit();
            pnl_FondoCrearSkate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpaquetado).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCrearRoller;
        private GroupBox grpSeleccionCrear;
        private RadioButton rdoPatinSobreHielo;
        private RadioButton rdoPatinFreeStyle;
        private RadioButton rdoPatinArtistico;
        private NumericUpDown numericUpDownCantidad;
        private Panel pnl_ContenedorDataGridSkate;
        private DataGridView dataGridViewRollers;
        private Panel pnl_FondoCrearSkate;
        private DataGridView dataGridStock;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btn_Empaquetar;
        private DataGridView dataGridViewEmpaquetado;
        private GroupBox groupBox1;
        private RadioButton rdoEmpaquetarSobreHielo;
        private RadioButton rdoEmpaquetarFreeStyle;
        private RadioButton rdoEmpaquetarArtistico;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn NumeroSerie;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn ApellidoOperario;
        private DataGridViewTextBoxColumn CantidadTotalDeEmpaquetado;
    }
}