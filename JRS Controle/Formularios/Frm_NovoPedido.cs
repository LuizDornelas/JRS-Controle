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
    public partial class Frm_NovoPedido : Form
    {
        double calc;
        public Frm_NovoPedido()
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

            lbl_parcelado.Visible = false;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string pedido = txt_pedido.Text;
                string nome = txt_nome.Text;
                string descricao = rtb_descricao.Text;
                string valor = txt_valor.Text;
                string pagamento = cmb_pagamento.Text;
                string status = cmb_status.Text;
                DateTime entrada = DateTime.Now;

                if (txt_valor.Text.Contains("."))
                {
                    MessageBox.Show($"Erro: Formato de valor incorreto", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_valor.Focus();
                }
                else if (txt_pedido.Text == "" || txt_nome.Text == "" || txt_valor.Text == "")
                {
                    MessageBox.Show($"Erro: Há campos vazios, preencha!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Clientes cliente = new Clientes();

                    if (pagamento == "2x")
                    {
                        pagamento = $"{pagamento} R${calc.ToString("F")}";
                    }

                    cliente.Pedido = pedido;
                    cliente.Nome = nome;
                    cliente.Descricao = descricao;
                    cliente.Valor = valor;
                    cliente.Pagamento = pagamento;
                    cliente.Status = status;
                    cliente.Data_entrada = entrada;

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
            txt_pedido.Text = "";
            txt_nome.Text = "";
            rtb_descricao.Text = "";
            txt_valor.Text = "";
            cmb_status.Text = "";
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txt_pedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
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
    }
}
