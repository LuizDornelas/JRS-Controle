using JRS_Controle.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRS_Controle.Formularios
{
    public partial class Frm_NovoUsuario : Form
    {
        public Frm_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_login.Text == "" || txt_senha.Text == "" || txt_confirma.Text == "")
                {
                    MessageBox.Show($"Erro: Há campos vazios, preencha!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else if (txt_senha.Text != txt_confirma.Text)
                {
                    MessageBox.Show($"Erro: Senha e confirmação divergentes", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Login login = new Login(txt_login.Text, txt_senha.Text);
                    
                    if (login.Cadastrar())
                    {
                        MessageBox.Show($"Usuário cadastrado com sucesso!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpacampos();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void limpacampos()
        {
            txt_login.Text = "";
            txt_senha.Text = "";
            txt_confirma.Text = "";
        }
    }
}
