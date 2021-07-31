
namespace JRS_Controle.Formularios
{
    partial class Frm_AtualizaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtualizaUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_login = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbl_datagrid = new System.Windows.Forms.Panel();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_login)).BeginInit();
            this.pbl_datagrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_login.Location = new System.Drawing.Point(426, 130);
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
            this.lbl_login.Location = new System.Drawing.Point(426, 107);
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
            this.lbl_titulo.Size = new System.Drawing.Size(389, 38);
            this.lbl_titulo.TabIndex = 28;
            this.lbl_titulo.Text = "Atualização de Usuários";
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
            this.txt_confirma.Location = new System.Drawing.Point(426, 318);
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
            this.lbl_confirma.Location = new System.Drawing.Point(426, 295);
            this.lbl_confirma.Name = "lbl_confirma";
            this.lbl_confirma.Size = new System.Drawing.Size(139, 21);
            this.lbl_confirma.TabIndex = 32;
            this.lbl_confirma.Text = "Confirma Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_senha.Location = new System.Drawing.Point(426, 223);
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
            this.lbl_senha.Location = new System.Drawing.Point(426, 200);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(110, 21);
            this.lbl_senha.TabIndex = 34;
            this.lbl_senha.Text = "Nova Senha:";
            // 
            // dgv_login
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_login.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_login.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_login.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_login.BackgroundColor = System.Drawing.Color.White;
            this.dgv_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_login.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_login.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_login.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_login.ColumnHeadersHeight = 21;
            this.dgv_login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_login.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_login.EnableHeadersVisualStyles = false;
            this.dgv_login.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_login.Location = new System.Drawing.Point(3, 3);
            this.dgv_login.Name = "dgv_login";
            this.dgv_login.ReadOnly = true;
            this.dgv_login.RowHeadersVisible = false;
            this.dgv_login.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_login.Size = new System.Drawing.Size(145, 225);
            this.dgv_login.TabIndex = 36;
            this.dgv_login.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_login.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_login.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_login.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_login.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_login.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_login.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_login.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_login.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_login.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_login.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_login.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_login.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_login.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_login.ThemeStyle.ReadOnly = true;
            this.dgv_login.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_login.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_login.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_login.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_login.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_login.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_login.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // pbl_datagrid
            // 
            this.pbl_datagrid.Controls.Add(this.dgv_login);
            this.pbl_datagrid.Location = new System.Drawing.Point(99, 107);
            this.pbl_datagrid.Name = "pbl_datagrid";
            this.pbl_datagrid.Size = new System.Drawing.Size(158, 237);
            this.pbl_datagrid.TabIndex = 37;
            // 
            // Frm_AtualizaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.pbl_datagrid);
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
            this.Name = "Frm_AtualizaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_login)).EndInit();
            this.pbl_datagrid.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2DataGridView dgv_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.Panel pbl_datagrid;
    }
}