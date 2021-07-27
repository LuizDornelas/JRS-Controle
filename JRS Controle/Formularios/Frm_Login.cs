using JRS_Controle.Classes;
using System;
using System.Windows.Forms;

namespace JRS_Controle.Formularios
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login objusuario = new Login();

            objusuario.Loginn = txtUsuario.Text;
            objusuario.Senha = txtSenha.Text;
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo vazio, preencha!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                if ((objusuario.logar()))
                {
                    this.Hide();
                    Frm_Principal form = new Frm_Principal(objusuario.Loginn);
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
