using JRS_Controle.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRS_Controle
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal(string name)
        {
            InitializeComponent();

            lbl_titulo.Text = $"Bem vindo, {name}!";

            preenchedgv();
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void preenchedgv()
        {
            double total = 0;
            int count = 0;
            dgv_clientes.Rows.Clear();
            dgv_clientes.DataSource = null;
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string datagrid = "SELECT * FROM public.clientes order by pedido;";

                NpgsqlCommand cmd = new NpgsqlCommand(datagrid, pgsqlConnection);

                NpgsqlDataReader dgv = cmd.ExecuteReader();

                foreach (var db in dgv)
                {
                    string pedido = dgv["pedido"].ToString();
                    string nome = dgv["nome"].ToString();
                    string descricao = dgv["descricao"].ToString();
                    double valor = Convert.ToDouble(dgv["valor"].ToString());
                    string status = dgv["status"].ToString();
                    DateTime data_entrada = Convert.ToDateTime(dgv["entrada"].ToString());

                    if (status == "Em andamento")
                    {
                        total += valor;
                        count += 1;
                    }

                    if (dgv["saida"].ToString() != "")
                    {
                        DateTime data_saida = Convert.ToDateTime(dgv["saida"].ToString());
                        string[] nova_linha = new string[]

                                                    {
                                                    pedido,
                                                    nome,
                                                    descricao,
                                                    valor.ToString("F"),
                                                    status,
                                                    data_entrada.ToString("dd/MM/yyyy HH:mm:ss"),
                                                    data_saida.ToString("dd/MM/yyyy HH:mm:ss")
        };
                        dgv_clientes.Rows.Add(nova_linha);
                    }
                    else
                    {
                        string[] nova_linha = new string[]

                                                    {
                                                    pedido,
                                                    nome,
                                                    descricao,
                                                    valor.ToString("F"),
                                                    status,
                                                    data_entrada.ToString("dd/MM/yyyy HH:mm:ss")
        };
                        dgv_clientes.Rows.Add(nova_linha);
                    }
                }
                lbl_quantidade.Text = $"Pendente pagamento: {count}";             
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preenchedgv();
        }
    }
}
