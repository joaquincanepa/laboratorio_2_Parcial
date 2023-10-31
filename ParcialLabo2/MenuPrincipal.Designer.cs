namespace ParcialLabo2
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            pnl_Menu_Lateral = new Panel();
            btn_MostrarUsuarios = new Button();
            pnl_Stock = new Panel();
            btn_ReponerStock = new Button();
            btnStock = new Button();
            btnFabricarRollers = new Button();
            btnCrearSkate = new Button();
            btnMenu = new Button();
            pnl_logo = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnl_MenuPrincipal = new Panel();
            pictureBox2 = new PictureBox();
            pnl_Menu_Lateral.SuspendLayout();
            pnl_Stock.SuspendLayout();
            pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_Menu_Lateral
            // 
            pnl_Menu_Lateral.AutoScroll = true;
            pnl_Menu_Lateral.BackColor = Color.FromArgb(11, 7, 17);
            pnl_Menu_Lateral.Controls.Add(btn_MostrarUsuarios);
            pnl_Menu_Lateral.Controls.Add(pnl_Stock);
            pnl_Menu_Lateral.Controls.Add(btnStock);
            pnl_Menu_Lateral.Controls.Add(btnFabricarRollers);
            pnl_Menu_Lateral.Controls.Add(btnCrearSkate);
            pnl_Menu_Lateral.Controls.Add(btnMenu);
            pnl_Menu_Lateral.Controls.Add(pnl_logo);
            pnl_Menu_Lateral.Dock = DockStyle.Left;
            pnl_Menu_Lateral.ForeColor = Color.Black;
            pnl_Menu_Lateral.Location = new Point(0, 0);
            pnl_Menu_Lateral.Name = "pnl_Menu_Lateral";
            pnl_Menu_Lateral.Size = new Size(250, 561);
            pnl_Menu_Lateral.TabIndex = 0;
            // 
            // btn_MostrarUsuarios
            // 
            btn_MostrarUsuarios.Dock = DockStyle.Top;
            btn_MostrarUsuarios.FlatAppearance.BorderSize = 0;
            btn_MostrarUsuarios.FlatStyle = FlatStyle.Flat;
            btn_MostrarUsuarios.ForeColor = Color.Gainsboro;
            btn_MostrarUsuarios.Location = new Point(0, 327);
            btn_MostrarUsuarios.Name = "btn_MostrarUsuarios";
            btn_MostrarUsuarios.Padding = new Padding(10, 0, 0, 0);
            btn_MostrarUsuarios.Size = new Size(250, 45);
            btn_MostrarUsuarios.TabIndex = 13;
            btn_MostrarUsuarios.Text = "Ver Usuarios";
            btn_MostrarUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_MostrarUsuarios.UseVisualStyleBackColor = true;
            btn_MostrarUsuarios.Click += btn_MostrarUsuarios_Click;
            // 
            // pnl_Stock
            // 
            pnl_Stock.BackColor = Color.FromArgb(35, 32, 39);
            pnl_Stock.Controls.Add(btn_ReponerStock);
            pnl_Stock.Dock = DockStyle.Top;
            pnl_Stock.Location = new Point(0, 280);
            pnl_Stock.Name = "pnl_Stock";
            pnl_Stock.Size = new Size(250, 47);
            pnl_Stock.TabIndex = 12;
            // 
            // btn_ReponerStock
            // 
            btn_ReponerStock.Dock = DockStyle.Top;
            btn_ReponerStock.FlatAppearance.BorderSize = 0;
            btn_ReponerStock.FlatStyle = FlatStyle.Flat;
            btn_ReponerStock.ForeColor = Color.Gainsboro;
            btn_ReponerStock.Location = new Point(0, 0);
            btn_ReponerStock.Name = "btn_ReponerStock";
            btn_ReponerStock.Padding = new Padding(35, 0, 0, 0);
            btn_ReponerStock.Size = new Size(250, 44);
            btn_ReponerStock.TabIndex = 10;
            btn_ReponerStock.Text = "Reponer Stock";
            btn_ReponerStock.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReponerStock.UseVisualStyleBackColor = true;
            btn_ReponerStock.Click += btn_ReponerStock_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.ForeColor = Color.Gainsboro;
            btnStock.Location = new Point(0, 235);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(10, 0, 0, 0);
            btnStock.Size = new Size(250, 45);
            btnStock.TabIndex = 11;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnFabricarRollers
            // 
            btnFabricarRollers.Dock = DockStyle.Top;
            btnFabricarRollers.FlatAppearance.BorderSize = 0;
            btnFabricarRollers.FlatStyle = FlatStyle.Flat;
            btnFabricarRollers.ForeColor = Color.Gainsboro;
            btnFabricarRollers.Location = new Point(0, 190);
            btnFabricarRollers.Name = "btnFabricarRollers";
            btnFabricarRollers.Padding = new Padding(10, 0, 0, 0);
            btnFabricarRollers.Size = new Size(250, 45);
            btnFabricarRollers.TabIndex = 9;
            btnFabricarRollers.Text = "Fabricar Rollers";
            btnFabricarRollers.TextAlign = ContentAlignment.MiddleLeft;
            btnFabricarRollers.UseVisualStyleBackColor = true;
            btnFabricarRollers.Click += btnFabricarRollers_Click;
            // 
            // btnCrearSkate
            // 
            btnCrearSkate.Dock = DockStyle.Top;
            btnCrearSkate.FlatAppearance.BorderSize = 0;
            btnCrearSkate.FlatStyle = FlatStyle.Flat;
            btnCrearSkate.ForeColor = Color.Gainsboro;
            btnCrearSkate.Location = new Point(0, 145);
            btnCrearSkate.Name = "btnCrearSkate";
            btnCrearSkate.Padding = new Padding(10, 0, 0, 0);
            btnCrearSkate.Size = new Size(250, 45);
            btnCrearSkate.TabIndex = 3;
            btnCrearSkate.Text = "Fabricar Skate";
            btnCrearSkate.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearSkate.UseVisualStyleBackColor = true;
            btnCrearSkate.Click += btnCrearSkate_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.Gainsboro;
            btnMenu.Location = new Point(0, 100);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(250, 45);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnl_logo
            // 
            pnl_logo.Controls.Add(pictureBox3);
            pnl_logo.Controls.Add(pictureBox1);
            pnl_logo.Dock = DockStyle.Top;
            pnl_logo.Location = new Point(0, 0);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(250, 100);
            pnl_logo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(115, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnl_MenuPrincipal
            // 
            pnl_MenuPrincipal.Controls.Add(pictureBox2);
            pnl_MenuPrincipal.Dock = DockStyle.Fill;
            pnl_MenuPrincipal.Location = new Point(250, 0);
            pnl_MenuPrincipal.Name = "pnl_MenuPrincipal";
            pnl_MenuPrincipal.Size = new Size(684, 561);
            pnl_MenuPrincipal.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(684, 561);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(pnl_MenuPrincipal);
            Controls.Add(pnl_Menu_Lateral);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(950, 600);
            MinimumSize = new Size(950, 600);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            pnl_Menu_Lateral.ResumeLayout(false);
            pnl_Stock.ResumeLayout(false);
            pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_MenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Menu_Lateral;
        private Button btnCrearSkate;
        private Button btnMenu;
        private Panel pnl_logo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel pnl_Stock;
        private Button btnStock;
        private Button btnFabricarRollers;
        private Panel pnl_MenuPrincipal;
        private PictureBox pictureBox2;
        private Button btn_ReponerStock;
        private Button btn_MostrarUsuarios;
    }
}