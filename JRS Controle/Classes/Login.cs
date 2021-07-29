using Npgsql;
using System;
using System.Windows.Forms;

namespace JRS_Controle.Classes
{
    class Login
    {
        private string login;
        private string senha;

        public Login(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public Login()
        {
        }

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
        public bool Cadastrar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = "select count(login) from login where login = '" + this.login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                int c = Convert.ToInt32(dr["count"].ToString());

                dr.Close();

                if (c == 0)
                {
                    sql = "INSERT INTO public.login(login, senha) VALUES ('" + this.login + "', '" + this.senha + "');";

                    cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    dr = cmd.ExecuteReader();

                    dr.Read();

                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário já existe!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool Atualizar()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string sql = "select count(login) from login where login = '" + this.login + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                int c = Convert.ToInt32(dr["count"].ToString());

                dr.Close();

                if (c == 1)
                {
                    sql = "UPDATE public.login SET senha='"+ this.senha +"' WHERE login = '"+ this.login +"';";

                    cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    dr = cmd.ExecuteReader();

                    dr.Read();

                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário não existe!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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