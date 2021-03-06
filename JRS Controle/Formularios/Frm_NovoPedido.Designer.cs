
namespace JRS_Controle.Formularios
{
    partial class Frm_NovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NovoPedido));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_direito = new System.Windows.Forms.Panel();
            this.pnl_esquerdo = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_img_titulo = new System.Windows.Forms.Panel();
            this.pnl_meio = new System.Windows.Forms.Panel();
            this.cmb_pagamento = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_pgto = new System.Windows.Forms.Label();
            this.lbl_parcelado = new System.Windows.Forms.Label();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nome.Location = new System.Drawing.Point(437, 141);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(514, 26);
            this.txt_nome.TabIndex = 22;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_valor.Location = new System.Drawing.Point(141, 215);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(86, 26);
            this.txt_valor.TabIndex = 20;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(141, 391);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(161, 28);
            this.cmb_status.TabIndex = 19;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_descricao.ForeColor = System.Drawing.Color.Black;
            this.lbl_descricao.Location = new System.Drawing.Point(437, 202);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(91, 21);
            this.lbl_descricao.TabIndex = 17;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_status.ForeColor = System.Drawing.Color.Black;
            this.lbl_status.Location = new System.Drawing.Point(137, 368);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(63, 21);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_valor.ForeColor = System.Drawing.Color.Black;
            this.lbl_valor.Location = new System.Drawing.Point(137, 192);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(97, 21);
            this.lbl_valor.TabIndex = 15;
            this.lbl_valor.Text = "Valor Total:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(437, 118);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(121, 21);
            this.lbl_nome.TabIndex = 14;
            this.lbl_nome.Text = "Nome Cliente:";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pedido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_pedido.ForeColor = System.Drawing.Color.Black;
            this.lbl_pedido.Location = new System.Drawing.Point(137, 118);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(92, 21);
            this.lbl_pedido.TabIndex = 13;
            this.lbl_pedido.Text = "Nº pedido:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.ForeColor = System.Drawing.Color.Snow;
            this.btn_salvar.Location = new System.Drawing.Point(463, 489);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 47);
            this.btn_salvar.TabIndex = 25;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_descricao.Location = new System.Drawing.Point(437, 231);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(514, 167);
            this.rtb_descricao.TabIndex = 27;
            this.rtb_descricao.Text = "";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(380, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(340, 38);
            this.lbl_titulo.TabIndex = 28;
            this.lbl_titulo.Text = "Cadastro de Pedidos";
            // 
            // pnl_direito
            // 
            this.pnl_direito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_direito.Location = new System.Drawing.Point(1027, -6);
            this.pnl_direito.Name = "pnl_direito";
            this.pnl_direito.Size = new System.Drawing.Size(2, 627);
            this.pnl_direito.TabIndex = 29;
            // 
            // pnl_esquerdo
            // 
            this.pnl_esquerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_esquerdo.Location = new System.Drawing.Point(51, -6);
            this.pnl_esquerdo.Name = "pnl_esquerdo";
            this.pnl_esquerdo.Size = new System.Drawing.Size(2, 629);
            this.pnl_esquerdo.TabIndex = 30;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnl_titulo.Controls.Add(this.pnl_img_titulo);
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Location = new System.Drawing.Point(-11, -6);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1096, 70);
            this.pnl_titulo.TabIndex = 31;
            // 
            // pnl_img_titulo
            // 
            this.pnl_img_titulo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_img_titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_img_titulo.BackgroundImage")));
            this.pnl_img_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_img_titulo.Location = new System.Drawing.Point(335, 13);
            this.pnl_img_titulo.Name = "pnl_img_titulo";
            this.pnl_img_titulo.Size = new System.Drawing.Size(44, 49);
            this.pnl_img_titulo.TabIndex = 32;
            // 
            // pnl_meio
            // 
            this.pnl_meio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_meio.Location = new System.Drawing.Point(100, 448);
            this.pnl_meio.Name = "pnl_meio";
            this.pnl_meio.Size = new System.Drawing.Size(885, 2);
            this.pnl_meio.TabIndex = 23;
            // 
            // cmb_pagamento
            // 
            this.cmb_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_pagamento.FormattingEnabled = true;
            this.cmb_pagamento.Location = new System.Drawing.Point(141, 297);
            this.cmb_pagamento.Name = "cmb_pagamento";
            this.cmb_pagamento.Size = new System.Drawing.Size(161, 28);
            this.cmb_pagamento.TabIndex = 33;
            this.cmb_pagamento.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // lbl_tipo_pgto
            // 
            this.lbl_tipo_pgto.AutoSize = true;
            this.lbl_tipo_pgto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo_pgto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_tipo_pgto.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo_pgto.Location = new System.Drawing.Point(137, 274);
            this.lbl_tipo_pgto.Name = "lbl_tipo_pgto";
            this.lbl_tipo_pgto.Size = new System.Drawing.Size(150, 21);
            this.lbl_tipo_pgto.TabIndex = 32;
            this.lbl_tipo_pgto.Text = "Meio Pagamento:";
            // 
            // lbl_parcelado
            // 
            this.lbl_parcelado.AutoSize = true;
            this.lbl_parcelado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parcelado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_parcelado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbl_parcelado.Location = new System.Drawing.Point(137, 328);
            this.lbl_parcelado.Name = "lbl_parcelado";
            this.lbl_parcelado.Size = new System.Drawing.Size(148, 21);
            this.lbl_parcelado.TabIndex = 34;
            this.lbl_parcelado.Text = "* Valor Parcelado:";
            // 
            // txt_pedido
            // 
            this.txt_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_pedido.Location = new System.Drawing.Point(141, 141);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(86, 26);
            this.txt_pedido.TabIndex = 35;
            this.txt_pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pedido_KeyPress);
            // 
            // Frm_NovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.txt_pedido);
            this.Controls.Add(this.lbl_parcelado);
            this.Controls.Add(this.cmb_pagamento);
            this.Controls.Add(this.lbl_tipo_pgto);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_direito);
            this.Controls.Add(this.pnl_esquerdo);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.pnl_meio);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_pedido);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_direito;
        private System.Windows.Forms.Panel pnl_esquerdo;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_meio;
        private System.Windows.Forms.Panel pnl_img_titulo;
        private System.Windows.Forms.ComboBox cmb_pagamento;
        private System.Windows.Forms.Label lbl_tipo_pgto;
        private System.Windows.Forms.Label lbl_parcelado;
        private System.Windows.Forms.TextBox txt_pedido;
    }
}