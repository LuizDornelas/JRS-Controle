using JRS_Controle.Classes;
using JRS_Controle.Formularios;
using Npgsql;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JRS_Controle
{
    public partial class Frm_Principal : Form
    {
        string nome;        
        public Frm_Principal(string name)
        {
            InitializeComponent();            

            nome = name;

            AbrirForm(new Frm_Dashboard(nome));            
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
        private void AbrirForm(object form)
        {
            if (this.pnl_principal.Controls.Count > 0)
            {
                this.pnl_principal.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_principal.Controls.Add(fh);
            this.pnl_principal.Tag = fh;
            fh.Show();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_NovoPedido());
        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_Dashboard(nome));
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_AtualizarPedido());
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_NovoUsuario());
        }

        private void btn_atualiza_usuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_AtualizaUsuario());
        }
    }
}
