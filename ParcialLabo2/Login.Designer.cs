namespace TrabajoPracticoIntegrador
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHarcodeo = new Button();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            lbl_login = new Label();
            btn_ingresar = new Button();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cancelar = new Button();
            btnCrearUsuario = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHarcodeo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 428);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnHarcodeo
            // 
            btnHarcodeo.BackColor = Color.FromArgb(40, 40, 40);
            btnHarcodeo.FlatAppearance.BorderSize = 0;
            btnHarcodeo.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnHarcodeo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnHarcodeo.FlatStyle = FlatStyle.Flat;
            btnHarcodeo.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHarcodeo.ForeColor = Color.Gainsboro;
            btnHarcodeo.Location = new Point(12, 385);
            btnHarcodeo.Name = "btnHarcodeo";
            btnHarcodeo.Size = new Size(105, 31);
            btnHarcodeo.TabIndex = 9;
            btnHarcodeo.Text = "harcodeo";
            btnHarcodeo.UseVisualStyleBackColor = false;
            btnHarcodeo.Click += btnHarcodeo_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.ActiveCaptionText;
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.ForeColor = Color.DimGray;
            txt_usuario.Location = new Point(285, 66);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(403, 32);
            txt_usuario.TabIndex = 1;
            txt_usuario.Text = "USUARIO";
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            txt_usuario.Enter += txt_usuario_Enter;
            txt_usuario.Leave += txt_usuario_Leave;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.ActiveCaptionText;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.ForeColor = Color.DimGray;
            txt_password.Location = new Point(285, 139);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(403, 32);
            txt_password.TabIndex = 2;
            txt_password.Text = "CONTRASEÑA";
            txt_password.TextChanged += txt_password_TextChanged;
            txt_password.Enter += txt_password_Enter;
            txt_password.Leave += txt_password_Leave;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.DimGray;
            lbl_login.Location = new Point(450, 12);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(104, 31);
            lbl_login.TabIndex = 7;
            lbl_login.Text = "LOGIN";
            lbl_login.Click += lbl_login_Click;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(40, 40, 40);
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresar.ForeColor = Color.Gainsboro;
            btn_ingresar.Location = new Point(326, 225);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(403, 40);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(773, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(15, 15);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 5;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(728, 12);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 20);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 6;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(40, 40, 40);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.Gainsboro;
            btn_cancelar.Location = new Point(326, 291);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(403, 40);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCrearUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearUsuario.ForeColor = Color.Gainsboro;
            btnCrearUsuario.Location = new Point(625, 370);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(142, 31);
            btnCrearUsuario.TabIndex = 8;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 428);
            Controls.Add(btnCrearUsuario);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_minimizar);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_ingresar);
            Controls.Add(lbl_login);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Label lbl_login;
        private Button btn_ingresar;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private Button btn_cancelar;
        private Button btnCrearUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnHarcodeo;
        private PictureBox pictureBox1;
    }
}