using JRS_Controle.Classes;
using Npgsql;
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
    public partial class Frm_AtualizaUsuario : Form
    {
        public Frm_AtualizaUsuario()
        {
            InitializeComponent();

            preenchedgv();
        }
        private void preenchedgv()
        {
            dgv_login.Rows.Clear();
            dgv_login.DataSource = null;
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "SELECT login FROM public.login order by login;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                foreach (var db in dgv)
                {
                    string login = dgv["login"].ToString();

                    string[] nova_linha = new string[]

                                                {
                                                    login
    };
                    dgv_login.Rows.Add(nova_linha);
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
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

                    if (login.Atualizar())
                    {
                        MessageBox.Show($"Nova senha criada com sucesso!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
