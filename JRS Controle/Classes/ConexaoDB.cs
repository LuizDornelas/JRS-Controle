using Npgsql;

namespace JRS_Controle.Classes
{
    class ConexaoDB
    {
        public NpgsqlConnection getConexao()
        {
            NpgsqlConnection pgsqlConnection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres;Database=DadosJRS;");

            return pgsqlConnection;
        }
    }
}
