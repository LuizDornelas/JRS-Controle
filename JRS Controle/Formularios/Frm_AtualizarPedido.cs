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
    public partial class Frm_AtualizarPedido : Form
    {
        double calc;
        public Frm_AtualizarPedido()
        {
            InitializeComponent();

            cmb_status.Items.Clear();
            
            cmb_status.Items.Add("Aguardando material");
            cmb_status.Items.Add("Pendente pagamento");
            cmb_status.Items.Add("1ª Parcela Paga");
            cmb_status.Items.Add("Encerrado");
            cmb_status.SelectedItem = "Pendente pagamento";

            cmb_pagamento.Items.Clear();

            cmb_pagamento.Items.Add("À vista");
            cmb_pagamento.Items.Add("2x");
            cmb_pagamento.SelectedItem = "À vista";

            txt_busca.Focus();
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_busca.Text == "")
            {
                MessageBox.Show($"Erro: Utilize o campo de pesquisa!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_busca.Focus();
            }
            else if (txt_pedido.Text == "" || txt_nome.Text == "" || rtb_descricao.Text == "" || txt_valor.Text == "" || cmb_status.Text == "")
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
                    string pagamento = cmb_pagamento.Text;

                    if (pagamento == "2x")
                    {
                        pagamento = $"{pagamento} R${calc.ToString("F")}";
                    }

                    Clientes cliente = new Clientes(txt_busca.Text, txt_pedido.Text, txt_nome.Text, rtb_descricao.Text, txt_valor.Text, cmb_status.Text, pagamento, DateTime.Now);

                    if (cliente.Atualiza())
                    {
                        MessageBox.Show($"Pedido nº {txt_busca.Text} foi atualizado com sucesso!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_busca.Text = "";
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
            txt_pedido.Text = "";
            txt_nome.Text = "";
            rtb_descricao.Text = "";
            txt_valor.Text = "";
            cmb_status.Text = "";
        }        

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_busca.Text == "")
            {
                MessageBox.Show($"Erro: Utilize o campo de pesquisa!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_busca.Focus();
            }
            else
            {
                try
                {
                    Clientes cliente = new Clientes(txt_busca.Text);

                    if (cliente.Excluir())
                    {
                        txt_busca.Text = "";
                        limpacampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_busca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void txt_pedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_valor.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {
            limpacampos();
            try
            {
                if (txt_busca.Text != "")
                {
                    string busca = txt_busca.Text;

                    Clientes atualiza = new Clientes(busca);

                    if (atualiza.Pesquisa())
                    {
                        txt_pedido.Text = atualiza.Pedido;
                        txt_nome.Text = atualiza.Nome;
                        rtb_descricao.Text = atualiza.Descricao;
                        txt_valor.Text = atualiza.Valor.ToString();
                        cmb_status.Text = atualiza.Status;
                        cmb_pagamento.Text = atualiza.Pagamento;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            if (cmb_pagamento.SelectedItem.ToString() == "2x")
            {
                if (txt_valor.Text == "")
                {
                    lbl_parcelado.Visible = false;

                    lbl_parcelado.Text = "";
                }
                else
                {
                    calc = Convert.ToDouble(txt_valor.Text) / 2;

                    lbl_parcelado.Text = $"*Valor Parcelado: R${calc.ToString("F")}";

                    lbl_parcelado.Visible = true;
                }
            }
            else
            {
                lbl_parcelado.Visible = false;
            }
        }

        private void cmb_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pagamento.SelectedItem.ToString() == "2x")
            {
                if (txt_valor.Text != "")
                {
                    calc = Convert.ToDouble(txt_valor.Text) / 2;

                    lbl_parcelado.Text = $"*Valor Parcelado: R${calc.ToString("F")}";

                    lbl_parcelado.Visible = true;
                }
            }
            else
            {
                lbl_parcelado.Visible = false;
            }
        }
    }
}