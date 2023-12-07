namespace ParcialLabo2
{
    partial class FormCrearOperario
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
            dateDechaNacimientoCrearUsuarioOperario = new MonthCalendar();
            btnCrearUsuarioOperario = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_ContraseniaCrearUsuario
            // 
            lbl_ContraseniaCrearUsuario.Location = new Point(482, 92);
            // 
            // lblNombreCrearUsuario
            // 
            lblNombreCrearUsuario.Location = new Point(20, 22);
            // 
            // btnLimpiarDatosCrearUsuario
            // 
            btnLimpiarDatosCrearUsuario.BackColor = SystemColors.WindowText;
            btnLimpiarDatosCrearUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarDatosCrearUsuario.ForeColor = Color.WhiteSmoke;
            btnLimpiarDatosCrearUsuario.Location = new Point(212, 252);
            btnLimpiarDatosCrearUsuario.Size = new Size(133, 41);
            btnLimpiarDatosCrearUsuario.UseVisualStyleBackColor = false;
            btnLimpiarDatosCrearUsuario.Click += btnLimpiarDatosCrearUsuario_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(27, 25);
            btnCrearUsuario.Size = new Size(133, 18);
            // 
            // dateDechaNacimientoCrearUsuarioOperario
            // 
            dateDechaNacimientoCrearUsuarioOperario.BackColor = Color.FromArgb(11, 7, 17);
            dateDechaNacimientoCrearUsuarioOperario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateDechaNacimientoCrearUsuarioOperario.ForeColor = SystemColors.ButtonHighlight;
            dateDechaNacimientoCrearUsuarioOperario.Location = new Point(482, 208);
            dateDechaNacimientoCrearUsuarioOperario.Name = "dateDechaNacimientoCrearUsuarioOperario";
            dateDechaNacimientoCrearUsuarioOperario.TabIndex = 101;
            // 
            // btnCrearUsuarioOperario
            // 
            btnCrearUsuarioOperario.BackColor = SystemColors.WindowText;
            btnCrearUsuarioOperario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearUsuarioOperario.ForeColor = Color.WhiteSmoke;
            btnCrearUsuarioOperario.Location = new Point(38, 252);
            btnCrearUsuarioOperario.Name = "btnCrearUsuarioOperario";
            btnCrearUsuarioOperario.Size = new Size(133, 41);
            btnCrearUsuarioOperario.TabIndex = 102;
            btnCrearUsuarioOperario.Text = "Crear Operario";
            btnCrearUsuarioOperario.UseVisualStyleBackColor = false;
            btnCrearUsuarioOperario.Click += btnCrearUsuarioOperario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(27, 345);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 104;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(34, 318);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(278, 23);
            progressBar1.TabIndex = 105;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.WindowText;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.WhiteSmoke;
            btn_cancelar.Location = new Point(179, 347);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(133, 41);
            btn_cancelar.TabIndex = 106;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FormCrearOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(btnCrearUsuarioOperario);
            Controls.Add(dateDechaNacimientoCrearUsuarioOperario);
            Name = "FormCrearOperario";
            Text = "FormCrearOperario";
            Controls.SetChildIndex(dateDechaNacimientoCrearUsuarioOperario, 0);
            Controls.SetChildIndex(btnCrearUsuarioOperario, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lbl_ContraseniaCrearUsuario, 0);
            Controls.SetChildIndex(btnCrearUsuario, 0);
            Controls.SetChildIndex(btnLimpiarDatosCrearUsuario, 0);
            Controls.SetChildIndex(lblNombreCrearUsuario, 0);
            Controls.SetChildIndex(txtNombreCrearUsuario, 0);
            Controls.SetChildIndex(lblApellidoCrearUsuario, 0);
            Controls.SetChildIndex(txtApellidoCrearUsuario, 0);
            Controls.SetChildIndex(lblDniCrearUsuario, 0);
            Controls.SetChildIndex(txtDniCrearUsuario, 0);
            Controls.SetChildIndex(lblFechaNacimientoCrearUsuario, 0);
            Controls.SetChildIndex(lblEmailCrearUsuario, 0);
            Controls.SetChildIndex(txtEmailCrearUsuario, 0);
            Controls.SetChildIndex(txtPasswordCrearUsuario, 0);
            Controls.SetChildIndex(progressBar1, 0);
            Controls.SetChildIndex(btn_cancelar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar dateDechaNacimientoCrearUsuarioOperario;
        private Button btnCrearUsuarioOperario;
        private Label label1;
        private ProgressBar progressBar1;
        private Button btn_cancelar;
    }
}