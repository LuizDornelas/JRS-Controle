
namespace JRS_Controle.Formularios
{
    partial class Frm_Novo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Novo));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.msk_pedido = new System.Windows.Forms.MaskedTextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nome.Location = new System.Drawing.Point(310, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(514, 26);
            this.txt_nome.TabIndex = 22;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_valor.Location = new System.Drawing.Point(16, 94);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(86, 26);
            this.txt_valor.TabIndex = 20;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(16, 159);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(161, 28);
            this.cmb_status.TabIndex = 19;
            // 
            // msk_pedido
            // 
            this.msk_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msk_pedido.Location = new System.Drawing.Point(16, 32);
            this.msk_pedido.Mask = "000000000";
            this.msk_pedido.Name = "msk_pedido";
            this.msk_pedido.Size = new System.Drawing.Size(86, 26);
            this.msk_pedido.TabIndex = 18;
            this.msk_pedido.ValidatingType = typeof(int);
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_descricao.ForeColor = System.Drawing.Color.Black;
            this.lbl_descricao.Location = new System.Drawing.Point(310, 71);
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
            this.lbl_status.Location = new System.Drawing.Point(12, 136);
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
            this.lbl_valor.Location = new System.Drawing.Point(12, 71);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(54, 21);
            this.lbl_valor.TabIndex = 15;
            this.lbl_valor.Text = "Valor:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(310, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(61, 21);
            this.lbl_nome.TabIndex = 14;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pedido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_pedido.ForeColor = System.Drawing.Color.Black;
            this.lbl_pedido.Location = new System.Drawing.Point(12, 9);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(92, 21);
            this.lbl_pedido.TabIndex = 13;
            this.lbl_pedido.Text = "Nº pedido:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 2);
            this.panel1.TabIndex = 23;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.ForeColor = System.Drawing.Color.Snow;
            this.btn_salvar.Location = new System.Drawing.Point(339, 241);
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
            this.rtb_descricao.Location = new System.Drawing.Point(310, 100);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(514, 87);
            this.rtb_descricao.TabIndex = 27;
            this.rtb_descricao.Text = "";
            // 
            // Frm_Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 328);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.msk_pedido);
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
            this.Name = "Frm_Novo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_status;
        public System.Windows.Forms.MaskedTextBox msk_pedido;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.RichTextBox rtb_descricao;
    }
}