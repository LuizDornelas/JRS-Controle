using Npgsql;
using System;
using System.Windows.Forms;

namespace JRS_Controle.Classes
{
    class Clientes
    {
        private string busca;
        private string pedido;
        private string nome;
        private string descricao;
        private string valor;
        private string status;
        private DateTime data_entrada;
        private DateTime data_saida;
        public string Pedido
        {
            get
            {
                return this.pedido;
            }
            set
            {
                this.pedido = value;
            }
        }
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }
        public string Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.valor = value;
            }
        }
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        public DateTime Data_entrada
        {
            get
            {
                return this.data_entrada;
            }
            set
            {
                this.data_entrada = value;
            }
        }
        public DateTime Data_saida
        {
            get
            {
                return this.data_saida;
            }
            set
            {
                this.data_saida = value;
            }
        }
        public string Busca
        {
            get
            {
                return this.busca;
            }
            set
            {
                this.busca = value;
            }
        }
        public Clientes(string pedido, string nome, string descricao, string valor, string status, DateTime data_entrada)
        {
            this.pedido = pedido;
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
            this.status = status;
            this.data_entrada = data_entrada;
        }
        public Clientes(string busca)
        {
            this.busca = busca;
        }
        public Clientes(string busca, string pedido, string nome, string descricao, string valor, string status, DateTime data_entrada)
        {
            this.busca = busca;
            this.pedido = pedido;
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
            this.status = status;
            this.data_entrada = data_entrada;
        }

        public bool Cadastro()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "SELECT count (pedido) FROM clientes where pedido = '" + this.pedido + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader qr = cmd.ExecuteReader();

                qr.Read();

                string criterio = qr["count"].ToString();

                qr.Close();

                if (criterio == "0")
                {
                    querry = "INSERT INTO public.clientes(pedido, nome, descricao, valor, status, entrada) VALUES ('" + this.pedido + "', '" + this.nome + "', '" + this.descricao + "', '" + this.valor + "', '" + this.status + "', '" + this.data_entrada + "');";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    qr = cmd.ExecuteReader();

                    return true;
                }
                else
                {
                    MessageBox.Show($"Número do pedido já cadastrado no sistema!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool Pesquisa()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "SELECT count (pedido) FROM clientes where pedido = '" + this.busca + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader qr = cmd.ExecuteReader();

                qr.Read();

                string criterio = qr["count"].ToString();

                qr.Close();

                if (criterio == "1")
                {
                    querry = "select * from clientes where pedido = '" + this.busca + "';";

                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    qr = cmd.ExecuteReader();

                    qr.Read();

                    this.pedido = qr["pedido"].ToString();
                    this.nome = qr["nome"].ToString();
                    this.descricao = qr["descricao"].ToString();
                    this.valor = qr["valor"].ToString();
                    this.status = qr["status"].ToString();

                    qr.Close();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool Atualiza()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "SELECT count (pedido) FROM clientes where pedido = '" + this.busca + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader qr = cmd.ExecuteReader();

                qr.Read();

                string criterio = qr["count"].ToString();

                qr.Close();

                if (criterio == "1")
                {
                    if (this.status == "Encerrado")
                    {
                        querry = "UPDATE public.clientes SET pedido='" + this.pedido + "', nome='" + this.nome + "', descricao='" + this.descricao + "', valor='" + this.valor + "', status='" + this.status + "', saida='" + DateTime.Now + "' WHERE pedido = '" + this.busca + "';";
                    }
                    else
                    {
                        querry = "UPDATE public.clientes SET pedido='" + this.pedido + "', nome='" + this.nome + "', descricao='" + this.descricao + "', valor='" + this.valor + "', status='" + this.status + "' WHERE pedido = '" + this.busca + "';";
                    }
                    cmd = new NpgsqlCommand(querry, pgsqlConnection);

                    qr = cmd.ExecuteReader();

                    return true;
                }
                else
                {
                    MessageBox.Show($"Erro: Esse pedido não existe!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public bool Excluir()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                ConexaoDB objconexao = new ConexaoDB();

                pgsqlConnection = objconexao.getConexao();
                pgsqlConnection.Open();

                string querry = "SELECT count (pedido) FROM clientes where pedido = '" + this.busca + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(querry, pgsqlConnection);

                NpgsqlDataReader qr = cmd.ExecuteReader();

                qr.Read();

                string criterio = qr["count"].ToString();

                qr.Close();

                if (criterio == "1")
                {
                    DialogResult excluir = new DialogResult();

                    excluir = MessageBox.Show($"Tem certeza que deseja excluir o pedido nº{this.busca}?", "Mensagem de Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (excluir == DialogResult.Yes)
                    {
                        querry = "DELETE FROM public.clientes WHERE pedido ='" + this.busca + "';";

                        cmd = new NpgsqlCommand(querry, pgsqlConnection);

                        qr = cmd.ExecuteReader();

                        MessageBox.Show($"O pedido foi excluído!", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"O pedido não foi excluído", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return false;
                    }                    
                }
                else
                {
                    MessageBox.Show($"Erro: Esse pedido não existe!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
