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
            SuspendLayout();
            // 
            // btnLimpiarDatosCrearUsuario
            // 
            btnLimpiarDatosCrearUsuario.Click += btnLimpiarDatosCrearUsuario_Click;
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
            btnCrearUsuarioOperario.Location = new Point(38, 319);
            btnCrearUsuarioOperario.Name = "btnCrearUsuarioOperario";
            btnCrearUsuarioOperario.Size = new Size(133, 23);
            btnCrearUsuarioOperario.TabIndex = 102;
            btnCrearUsuarioOperario.Text = "Crear Operario";
            btnCrearUsuarioOperario.UseVisualStyleBackColor = true;
            btnCrearUsuarioOperario.Click += btnCrearUsuarioOperario_Click;
            // 
            // FormCrearOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearUsuarioOperario);
            Controls.Add(dateDechaNacimientoCrearUsuarioOperario);
            Name = "FormCrearOperario";
            Text = "FormCrearOperario";
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
            Controls.SetChildIndex(dateDechaNacimientoCrearUsuarioOperario, 0);
            Controls.SetChildIndex(btnCrearUsuarioOperario, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar dateDechaNacimientoCrearUsuarioOperario;
        private Button btnCrearUsuarioOperario;
    }
}