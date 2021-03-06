
namespace JRS_Controle.Formularios
{
    partial class Frm_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcb_gif = new System.Windows.Forms.PictureBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dgv_clientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.N_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.lbl_busca = new System.Windows.Forms.Label();
            this.pnl_principal.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_principal
            // 
            this.pnl_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnl_principal.Controls.Add(this.txt_busca);
            this.pnl_principal.Controls.Add(this.lbl_busca);
            this.pnl_principal.Controls.Add(this.panel5);
            this.pnl_principal.Controls.Add(this.btn_refresh);
            this.pnl_principal.Controls.Add(this.dgv_clientes);
            this.pnl_principal.Controls.Add(this.lbl_titulo);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1097, 616);
            this.pnl_principal.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pcb_gif);
            this.panel5.Controls.Add(this.lbl_quantidade);
            this.panel5.Location = new System.Drawing.Point(33, 564);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 52);
            this.panel5.TabIndex = 7;
            // 
            // pcb_gif
            // 
            this.pcb_gif.BackColor = System.Drawing.Color.Transparent;
            this.pcb_gif.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pcb_gif.Image = ((System.Drawing.Image)(resources.GetObject("pcb_gif.Image")));
            this.pcb_gif.Location = new System.Drawing.Point(3, 2);
            this.pcb_gif.Name = "pcb_gif";
            this.pcb_gif.Size = new System.Drawing.Size(38, 47);
            this.pcb_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_gif.TabIndex = 21;
            this.pcb_gif.TabStop = false;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.ForeColor = System.Drawing.Color.White;
            this.lbl_quantidade.Location = new System.Drawing.Point(47, 12);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(223, 22);
            this.lbl_quantidade.TabIndex = 0;
            this.lbl_quantidade.Text = "Pendente pagamento:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(1039, 76);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(38, 40);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dgv_clientes
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_clientes.ColumnHeadersHeight = 21;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_pedido,
            this.Nome,
            this.Descricao,
            this.Valor,
            this.Pagamento,
            this.Status,
            this.Data_Entrada,
            this.Data_Saida});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_clientes.Location = new System.Drawing.Point(33, 76);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(1006, 482);
            this.dgv_clientes.TabIndex = 2;
            this.dgv_clientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_clientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_clientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_clientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_clientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_clientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_clientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_clientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_clientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgv_clientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_clientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_clientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_clientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_clientes.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_clientes.ThemeStyle.ReadOnly = true;
            this.dgv_clientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_clientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_clientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_clientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_clientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_clientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_clientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // N_pedido
            // 
            this.N_pedido.HeaderText = "Nº pedido";
            this.N_pedido.Name = "N_pedido";
            this.N_pedido.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Data_Entrada
            // 
            this.Data_Entrada.HeaderText = "Data Entrada";
            this.Data_Entrada.Name = "Data_Entrada";
            this.Data_Entrada.ReadOnly = true;
            // 
            // Data_Saida
            // 
            this.Data_Saida.HeaderText = "Data Saida";
            this.Data_Saida.Name = "Data_Saida";
            this.Data_Saida.ReadOnly = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(28, 32);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(142, 30);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Bem vindo";
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_busca.Location = new System.Drawing.Point(947, 50);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(86, 26);
            this.txt_busca.TabIndex = 39;
            this.txt_busca.TextChanged += new System.EventHandler(this.txt_busca_TextChanged);
            this.txt_busca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busca_KeyPress);
            // 
            // lbl_busca
            // 
            this.lbl_busca.AutoSize = true;
            this.lbl_busca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_busca.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbl_busca.ForeColor = System.Drawing.Color.White;
            this.lbl_busca.Location = new System.Drawing.Point(805, 51);
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(141, 22);
            this.lbl_busca.TabIndex = 38;
            this.lbl_busca.Text = "Busca pedido:";
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 616);
            this.Controls.Add(this.pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Dashboard";
            this.Text = "Frm_Dashboard";
            this.pnl_principal.ResumeLayout(false);
            this.pnl_principal.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Button btn_refresh;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_clientes;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.PictureBox pcb_gif;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Saida;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Label lbl_busca;
    }
}