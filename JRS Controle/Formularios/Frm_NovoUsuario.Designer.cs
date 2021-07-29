
namespace JRS_Controle.Formularios
{
    partial class Frm_NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NovoUsuario));
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_direito = new System.Windows.Forms.Panel();
            this.pnl_esquerdo = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_img_titulo = new System.Windows.Forms.Panel();
            this.pnl_meio = new System.Windows.Forms.Panel();
            this.txt_confirma = new System.Windows.Forms.TextBox();
            this.lbl_confirma = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_login.Location = new System.Drawing.Point(424, 153);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(214, 26);
            this.txt_login.TabIndex = 22;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_login.ForeColor = System.Drawing.Color.Black;
            this.lbl_login.Location = new System.Drawing.Point(424, 130);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(55, 21);
            this.lbl_login.TabIndex = 14;
            this.lbl_login.Text = "Login:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.ForeColor = System.Drawing.Color.Snow;
            this.btn_salvar.Location = new System.Drawing.Point(473, 475);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 47);
            this.btn_salvar.TabIndex = 25;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(380, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(344, 38);
            this.lbl_titulo.TabIndex = 28;
            this.lbl_titulo.Text = "Cadastro de Usuários";
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
            this.pnl_img_titulo.Location = new System.Drawing.Point(336, 16);
            this.pnl_img_titulo.Name = "pnl_img_titulo";
            this.pnl_img_titulo.Size = new System.Drawing.Size(44, 40);
            this.pnl_img_titulo.TabIndex = 32;
            // 
            // pnl_meio
            // 
            this.pnl_meio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_meio.Location = new System.Drawing.Point(99, 376);
            this.pnl_meio.Name = "pnl_meio";
            this.pnl_meio.Size = new System.Drawing.Size(885, 2);
            this.pnl_meio.TabIndex = 23;
            // 
            // txt_confirma
            // 
            this.txt_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_confirma.Location = new System.Drawing.Point(424, 328);
            this.txt_confirma.Name = "txt_confirma";
            this.txt_confirma.PasswordChar = '*';
            this.txt_confirma.Size = new System.Drawing.Size(214, 26);
            this.txt_confirma.TabIndex = 33;
            // 
            // lbl_confirma
            // 
            this.lbl_confirma.AutoSize = true;
            this.lbl_confirma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirma.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_confirma.ForeColor = System.Drawing.Color.Black;
            this.lbl_confirma.Location = new System.Drawing.Point(424, 305);
            this.lbl_confirma.Name = "lbl_confirma";
            this.lbl_confirma.Size = new System.Drawing.Size(139, 21);
            this.lbl_confirma.TabIndex = 32;
            this.lbl_confirma.Text = "Confirma Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_senha.Location = new System.Drawing.Point(424, 243);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(214, 26);
            this.txt_senha.TabIndex = 35;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(424, 220);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(63, 21);
            this.lbl_senha.TabIndex = 34;
            this.lbl_senha.Text = "Senha:";
            // 
            // Frm_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_confirma);
            this.Controls.Add(this.lbl_confirma);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_direito);
            this.Controls.Add(this.pnl_esquerdo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.pnl_meio);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_login);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_direito;
        private System.Windows.Forms.Panel pnl_esquerdo;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_meio;
        private System.Windows.Forms.Panel pnl_img_titulo;
        private System.Windows.Forms.TextBox txt_confirma;
        private System.Windows.Forms.Label lbl_confirma;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_senha;
    }
}