namespace CanepaJoaquinParcial
{
    partial class FrmTamanioFuente
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
            lbl_TituloConfigApp = new Label();
            manuItem = new GroupBox();
            radXl = new RadioButton();
            radGrande = new RadioButton();
            radMediano = new RadioButton();
            btnGuardarConfiguracion = new Button();
            manuItem.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_TituloConfigApp
            // 
            lbl_TituloConfigApp.AutoSize = true;
            lbl_TituloConfigApp.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloConfigApp.ForeColor = SystemColors.ButtonHighlight;
            lbl_TituloConfigApp.Location = new Point(161, 34);
            lbl_TituloConfigApp.Name = "lbl_TituloConfigApp";
            lbl_TituloConfigApp.Size = new Size(517, 35);
            lbl_TituloConfigApp.TabIndex = 8;
            lbl_TituloConfigApp.Text = "Elegi tu configuracion Deseada";
            // 
            // manuItem
            // 
            manuItem.AutoSize = true;
            manuItem.Controls.Add(radXl);
            manuItem.Controls.Add(radGrande);
            manuItem.Controls.Add(radMediano);
            manuItem.ForeColor = SystemColors.ButtonHighlight;
            manuItem.Location = new Point(54, 175);
            manuItem.Name = "manuItem";
            manuItem.Size = new Size(200, 162);
            manuItem.TabIndex = 7;
            manuItem.TabStop = false;
            manuItem.Text = "Tamaño";
            // 
            // radXl
            // 
            radXl.AutoSize = true;
            radXl.ForeColor = SystemColors.ButtonHighlight;
            radXl.Location = new Point(30, 121);
            radXl.Name = "radXl";
            radXl.Size = new Size(38, 19);
            radXl.TabIndex = 2;
            radXl.TabStop = true;
            radXl.Text = "XL";
            radXl.UseVisualStyleBackColor = true;
            radXl.CheckedChanged += radXl_CheckedChanged;
            // 
            // radGrande
            // 
            radGrande.AutoSize = true;
            radGrande.ForeColor = SystemColors.ButtonHighlight;
            radGrande.Location = new Point(30, 84);
            radGrande.Name = "radGrande";
            radGrande.Size = new Size(63, 19);
            radGrande.TabIndex = 1;
            radGrande.TabStop = true;
            radGrande.Text = "Grande";
            radGrande.UseVisualStyleBackColor = true;
            radGrande.CheckedChanged += radGrande_CheckedChanged;
            // 
            // radMediano
            // 
            radMediano.AutoSize = true;
            radMediano.ForeColor = SystemColors.ButtonHighlight;
            radMediano.Location = new Point(30, 41);
            radMediano.Name = "radMediano";
            radMediano.Size = new Size(72, 19);
            radMediano.TabIndex = 3;
            radMediano.TabStop = true;
            radMediano.Text = "Mediano";
            radMediano.UseVisualStyleBackColor = true;
            radMediano.CheckedChanged += radMediano_CheckedChanged;
            // 
            // btnGuardarConfiguracion
            // 
            btnGuardarConfiguracion.AutoSize = true;
            btnGuardarConfiguracion.BackColor = SystemColors.WindowText;
            btnGuardarConfiguracion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarConfiguracion.ForeColor = Color.WhiteSmoke;
            btnGuardarConfiguracion.Location = new Point(363, 242);
            btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            btnGuardarConfiguracion.Size = new Size(229, 73);
            btnGuardarConfiguracion.TabIndex = 9;
            btnGuardarConfiguracion.Text = "Guardar Configuracion";
            btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            btnGuardarConfiguracion.Click += btnGuardarConfiguracion_Click;
            // 
            // FrmTamanioFuente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarConfiguracion);
            Controls.Add(lbl_TituloConfigApp);
            Controls.Add(manuItem);
            Name = "FrmTamanioFuente";
            Text = "FrmTamanioFuente";
            manuItem.ResumeLayout(false);
            manuItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TituloConfigApp;
        private GroupBox manuItem;
        private RadioButton radXl;
        private RadioButton radGrande;
        private RadioButton radMediano;
        private Button btnGuardarConfiguracion;
    }
}