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
    public partial class Frm_Graficos : Form
    {
        public Frm_Graficos()
        {
            InitializeComponent();
        }

        private void tmr_data_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
