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
    public partial class Frm_Novo : Form
    {
        public Frm_Novo()
        {
            InitializeComponent();

            cmb_status.Items.Clear();

            cmb_status.Items.Add("Em andamento");
            cmb_status.Items.Add("Encerrado");
            cmb_status.SelectedItem = "Em andamento";
        }      
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string pedido = msk_pedido.Text;
                string nome = txt_nome.Text;
                string descricao = rtb_descricao.Text;
                string valor = txt_valor.Text;
                string status = cmb_status.Text;
                DateTime entrada = DateTime.Now;

                if (txt_valor.Text.Contains("."))
                {
                    MessageBox.Show($"Erro: Formato de valor incorreto", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_valor.Focus();
                }
                else
                {
                    Clientes cliente = new Clientes(pedido, nome, descricao, valor, status, entrada);

                    if (cliente.Cadastro())
                    {
                        MessageBox.Show($"Pedido nº {pedido} inserido com sucesso!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            msk_pedido.Text = "";
            txt_nome.Text = "";
            rtb_descricao.Text = "";
            txt_valor.Text = "";
            cmb_status.Text = "";
        }
    }
}
