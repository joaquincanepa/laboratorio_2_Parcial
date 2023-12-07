namespace CanepaJoaquinParcial
{
    partial class CuentaMisDatos
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
            btnConfirmarDatos = new Button();
            btnEditarDatos = new Button();
            txtEmail = new TextBox();
            txtDocumento = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblEmail = new Label();
            lblDocumento = new Label();
            lblFechaNacimiento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDatosPersonales = new Label();
            SuspendLayout();
            // 
            // btnConfirmarDatos
            // 
            btnConfirmarDatos.BackColor = SystemColors.WindowText;
            btnConfirmarDatos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarDatos.ForeColor = Color.WhiteSmoke;
            btnConfirmarDatos.Location = new Point(425, 469);
            btnConfirmarDatos.Name = "btnConfirmarDatos";
            btnConfirmarDatos.Size = new Size(174, 46);
            btnConfirmarDatos.TabIndex = 33;
            btnConfirmarDatos.Text = "Confirmar datos personales";
            btnConfirmarDatos.UseVisualStyleBackColor = false;
            btnConfirmarDatos.Click += btnConfirmarDatos_Click;
            // 
            // btnEditarDatos
            // 
            btnEditarDatos.BackColor = SystemColors.WindowText;
            btnEditarDatos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarDatos.ForeColor = Color.WhiteSmoke;
            btnEditarDatos.Location = new Point(115, 469);
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.Size = new Size(174, 46);
            btnEditarDatos.TabIndex = 32;
            btnEditarDatos.Text = "Editar Datos Personales";
            btnEditarDatos.UseVisualStyleBackColor = false;
            btnEditarDatos.Click += btnEditarDatos_Click;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(148, 303);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 30;
            // 
            // txtDocumento
            // 
            txtDocumento.Enabled = false;
            txtDocumento.Location = new Point(206, 241);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(150, 23);
            txtDocumento.TabIndex = 28;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Enabled = false;
            txtFechaNacimiento.Location = new Point(280, 195);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(159, 23);
            txtFechaNacimiento.TabIndex = 27;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(162, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(162, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 25;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(37, 299);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 24);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email :";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.Transparent;
            lblDocumento.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.ForeColor = SystemColors.ControlLightLight;
            lblDocumento.Location = new Point(37, 252);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(117, 24);
            lblDocumento.TabIndex = 21;
            lblDocumento.Text = "Documento :";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = SystemColors.ControlLightLight;
            lblFechaNacimiento.Location = new Point(37, 191);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(194, 24);
            lblFechaNacimiento.TabIndex = 20;
            lblFechaNacimiento.Text = "Fecha de nacimiento :";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(35, 138);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(93, 24);
            lblApellido.TabIndex = 19;
            lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(37, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 24);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre :";
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.BackColor = Color.Transparent;
            lblDatosPersonales.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosPersonales.ForeColor = SystemColors.ButtonHighlight;
            lblDatosPersonales.Location = new Point(303, 28);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(283, 43);
            lblDatosPersonales.TabIndex = 17;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // CuentaMisDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 7, 17);
            ClientSize = new Size(818, 622);
            Controls.Add(btnConfirmarDatos);
            Controls.Add(btnEditarDatos);
            Controls.Add(txtEmail);
            Controls.Add(txtDocumento);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblDocumento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosPersonales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuentaMisDatos";
            Text = "CuentaMisDatos";
            Load += CuentaMisDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarDatos;
        private Button btnEditarDatos;
        private TextBox txtEmail;
        private TextBox txtDocumento;
        private TextBox txtFechaNacimiento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblEmail;
        private Label lblDocumento;
        private Label lblFechaNacimiento;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDatosPersonales;
    }
}