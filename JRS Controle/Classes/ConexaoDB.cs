using Npgsql;

namespace JRS_Controle.Classes
{
    class ConexaoDB
    {
        public NpgsqlConnection getConexao()
        {
            NpgsqlConnection pgsqlConnection = new NpgsqlConnection("Server=34.95.196.148;Port=5432;User Id=postgres;Password=Jrs@1900;Database=DadosJRS;");

            return pgsqlConnection;
        }
    }
}
