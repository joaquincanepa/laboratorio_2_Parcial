namespace ParcialLabo2
{
    partial class FrmFotoMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFotoMenuPrincipal));
            pnl_FotoMenuPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            pnl_FotoMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_FotoMenuPrincipal
            // 
            pnl_FotoMenuPrincipal.Controls.Add(pictureBox1);
            pnl_FotoMenuPrincipal.Dock = DockStyle.Fill;
            pnl_FotoMenuPrincipal.Location = new Point(0, 0);
            pnl_FotoMenuPrincipal.Name = "pnl_FotoMenuPrincipal";
            pnl_FotoMenuPrincipal.Size = new Size(668, 522);
            pnl_FotoMenuPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(668, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FrmFotoMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 522);
            Controls.Add(pnl_FotoMenuPrincipal);
            MaximumSize = new Size(684, 561);
            MinimumSize = new Size(684, 561);
            Name = "FrmFotoMenuPrincipal";
            Text = "FrmFotoMenuPrincipal";
            pnl_FotoMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_FotoMenuPrincipal;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}