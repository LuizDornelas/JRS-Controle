using Npgsql;
using System;
using System.Windows.Forms;

namespace JRS_Controle.Classes
{
    class Login
    {
        private string login;
        private string senha;

        public string Loginn
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                this.senha = value;
            }
        }
        public bool logar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = "SELECT * FROM login WHERE login ='" + this.login + "' and senha='" + this.senha + "' LIMIT 1;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (this.login == dr["login"].ToString() && (this.senha) == dr["senha"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha divergentes", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
