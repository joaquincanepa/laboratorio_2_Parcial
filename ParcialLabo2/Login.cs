using ParcialLabo2;
using Entidades;

namespace TrabajoPracticoIntegrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "CONTRASEÑA")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.LightGray;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "CONTRASEÑA";
                txt_password.ForeColor = Color.DimGray;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();//esto corta con la ejecucion

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Estas seguro que quiere salir? ", "cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (Sistema.ValidarUsuario(txt_usuario.Text, txt_password.Text))
            {
                MenuPrincipal formMenuPrincipal = new MenuPrincipal();
                formMenuPrincipal.Show();
                MessageBox.Show("Bienvenido " + Sistema.UsuarioConectado.Nombre + " Usted ingreso en modo " + Sistema.UsuarioConectado.ObtenerTipoDeUsuario(), "Modo de ingreso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error de logeo, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FormSeleccionTipoUsuario frmSeleccionTipoUsuario = new FormSeleccionTipoUsuario();
            frmSeleccionTipoUsuario.Show();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnHarcodeo_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "@supervisor";
            txt_password.Text = "a";
            btn_ingresar_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}