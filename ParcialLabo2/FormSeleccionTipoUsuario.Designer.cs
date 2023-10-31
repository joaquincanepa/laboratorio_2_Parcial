namespace ParcialLabo2
{
    partial class FormSeleccionTipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionTipoUsuario));
            img_Operario = new PictureBox();
            btnOperarioSeleccionTipoUsuario = new Button();
            img_Supervisor = new PictureBox();
            btnSupervisorSeleccionTipoUsuario = new Button();
            lbl_login = new Label();
            panel1 = new Panel();
            btncancelarSeleccionTipoUsuario = new Button();
            pic_hospital = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_Operario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_Supervisor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_hospital).BeginInit();
            SuspendLayout();
            // 
            // img_Operario
            // 
            img_Operario.Image = (Image)resources.GetObject("img_Operario.Image");
            img_Operario.Location = new Point(632, 139);
            img_Operario.Name = "img_Operario";
            img_Operario.Size = new Size(55, 65);
            img_Operario.SizeMode = PictureBoxSizeMode.Zoom;
            img_Operario.TabIndex = 27;
            img_Operario.TabStop = false;
            // 
            // btnOperarioSeleccionTipoUsuario
            // 
            btnOperarioSeleccionTipoUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnOperarioSeleccionTipoUsuario.FlatAppearance.BorderSize = 0;
            btnOperarioSeleccionTipoUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnOperarioSeleccionTipoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnOperarioSeleccionTipoUsuario.FlatStyle = FlatStyle.Flat;
            btnOperarioSeleccionTipoUsuario.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperarioSeleccionTipoUsuario.ForeColor = Color.Gainsboro;
            btnOperarioSeleccionTipoUsuario.Location = new Point(557, 80);
            btnOperarioSeleccionTipoUsuario.Name = "btnOperarioSeleccionTipoUsuario";
            btnOperarioSeleccionTipoUsuario.Size = new Size(207, 40);
            btnOperarioSeleccionTipoUsuario.TabIndex = 25;
            btnOperarioSeleccionTipoUsuario.Text = "OPERARIO";
            btnOperarioSeleccionTipoUsuario.UseVisualStyleBackColor = false;
            btnOperarioSeleccionTipoUsuario.Click += btnOperarioSeleccionTipoUsuario_Click;
            // 
            // img_Supervisor
            // 
            img_Supervisor.Image = (Image)resources.GetObject("img_Supervisor.Image");
            img_Supervisor.Location = new Point(397, 139);
            img_Supervisor.Name = "img_Supervisor";
            img_Supervisor.Size = new Size(55, 65);
            img_Supervisor.SizeMode = PictureBoxSizeMode.Zoom;
            img_Supervisor.TabIndex = 21;
            img_Supervisor.TabStop = false;
            // 
            // btnSupervisorSeleccionTipoUsuario
            // 
            btnSupervisorSeleccionTipoUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnSupervisorSeleccionTipoUsuario.FlatAppearance.BorderSize = 0;
            btnSupervisorSeleccionTipoUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnSupervisorSeleccionTipoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSupervisorSeleccionTipoUsuario.FlatStyle = FlatStyle.Flat;
            btnSupervisorSeleccionTipoUsuario.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupervisorSeleccionTipoUsuario.ForeColor = Color.Gainsboro;
            btnSupervisorSeleccionTipoUsuario.Location = new Point(325, 80);
            btnSupervisorSeleccionTipoUsuario.Name = "btnSupervisorSeleccionTipoUsuario";
            btnSupervisorSeleccionTipoUsuario.Size = new Size(207, 40);
            btnSupervisorSeleccionTipoUsuario.TabIndex = 23;
            btnSupervisorSeleccionTipoUsuario.Text = "SUPERVISOR";
            btnSupervisorSeleccionTipoUsuario.UseVisualStyleBackColor = false;
            btnSupervisorSeleccionTipoUsuario.Click += btnSupervisorSeleccionTipoUsuario_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.DimGray;
            lbl_login.Location = new Point(325, 19);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(418, 31);
            lbl_login.TabIndex = 24;
            lbl_login.Text = "¿Que tipo de Usuario desea crear?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(btncancelarSeleccionTipoUsuario);
            panel1.Controls.Add(pic_hospital);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 248);
            panel1.TabIndex = 22;
            // 
            // btncancelarSeleccionTipoUsuario
            // 
            btncancelarSeleccionTipoUsuario.BackColor = Color.IndianRed;
            btncancelarSeleccionTipoUsuario.FlatAppearance.BorderSize = 0;
            btncancelarSeleccionTipoUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btncancelarSeleccionTipoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btncancelarSeleccionTipoUsuario.FlatStyle = FlatStyle.Flat;
            btncancelarSeleccionTipoUsuario.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelarSeleccionTipoUsuario.ForeColor = Color.Gainsboro;
            btncancelarSeleccionTipoUsuario.Location = new Point(47, 170);
            btncancelarSeleccionTipoUsuario.Name = "btncancelarSeleccionTipoUsuario";
            btncancelarSeleccionTipoUsuario.Size = new Size(149, 40);
            btncancelarSeleccionTipoUsuario.TabIndex = 9;
            btncancelarSeleccionTipoUsuario.Text = "CANCELAR";
            btncancelarSeleccionTipoUsuario.UseVisualStyleBackColor = false;
            btncancelarSeleccionTipoUsuario.Click += btncancelarSeleccionTipoUsuario_Click;
            // 
            // pic_hospital
            // 
            pic_hospital.Image = (Image)resources.GetObject("pic_hospital.Image");
            pic_hospital.Location = new Point(69, 71);
            pic_hospital.Name = "pic_hospital";
            pic_hospital.Size = new Size(94, 67);
            pic_hospital.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hospital.TabIndex = 2;
            pic_hospital.TabStop = false;
            // 
            // FormSeleccionTipoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 248);
            Controls.Add(img_Operario);
            Controls.Add(btnOperarioSeleccionTipoUsuario);
            Controls.Add(img_Supervisor);
            Controls.Add(btnSupervisorSeleccionTipoUsuario);
            Controls.Add(lbl_login);
            Controls.Add(panel1);
            Name = "FormSeleccionTipoUsuario";
            Text = "FormSeleccionTipoUsuario";
            ((System.ComponentModel.ISupportInitialize)img_Operario).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_Supervisor).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_hospital).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_Operario;
        private Button btnOperarioSeleccionTipoUsuario;
        private PictureBox pic_medico;
        private PictureBox img_Supervisor;
        private Button btnSupervisorSeleccionTipoUsuario;
        private Label lbl_login;
        private Panel panel1;
        private Button btncancelarSeleccionTipoUsuario;
        private PictureBox pic_hospital;
    }
}