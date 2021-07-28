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
    public partial class Frm_Atualizar : Form
    {
        public Frm_Atualizar()
        {
            InitializeComponent();

            cmb_status.Items.Clear();

            cmb_status.Items.Add("Em andamento");
            cmb_status.Items.Add("Aguardando material");
            cmb_status.Items.Add("Pendente pagamento");
            cmb_status.Items.Add("Encerrado");
            cmb_status.SelectedItem = "Em andamento";

            msk_busca.Focus();
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (msk_busca.Text == "")
            {
                MessageBox.Show($"Erro: Utilize o campo de pesquisa!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_busca.Focus();
            }
            else if (msk_pedido.Text == "" || txt_nome.Text == "" || rtb_descricao.Text == "" || txt_valor.Text == "" || cmb_status.Text == "")
            {
                MessageBox.Show($"Erro: Há campos vazios, preencha!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_valor.Text.Contains("."))
            {
                MessageBox.Show($"Erro: Formato de valor incorreto", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor.Focus();
            }
            else
            {
                try
                {
                    Clientes cliente = new Clientes(msk_busca.Text, msk_pedido.Text, txt_nome.Text, rtb_descricao.Text, txt_valor.Text, cmb_status.Text, DateTime.Now);

                    if (cliente.Atualiza())
                    {
                        MessageBox.Show($"Pedido nº {msk_busca.Text} foi atualizado com sucesso!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_busca.Text = "";
                        limpacampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void msk_busca_TextChanged(object sender, EventArgs e)
        {
            limpacampos();
            try
            {
                if (msk_busca.Text != "")
                {
                    string busca = msk_busca.Text;

                    Clientes atualiza = new Clientes(busca);

                    if (atualiza.Pesquisa())
                    {
                        msk_pedido.Text = atualiza.Pedido;
                        txt_nome.Text = atualiza.Nome;
                        rtb_descricao.Text = atualiza.Descricao;
                        txt_valor.Text = atualiza.Valor.ToString();
                        cmb_status.Text = atualiza.Status;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (msk_busca.Text == "")
            {
                MessageBox.Show($"Erro: Utilize o campo de pesquisa!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_busca.Focus();
            }
            else
            {
                try
                {
                    Clientes cliente = new Clientes(msk_busca.Text);

                    if (cliente.Excluir())
                    {
                        msk_busca.Text = "";
                        limpacampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}