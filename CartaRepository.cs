using Microsoft.Data.SqlClient;

namespace BancoDadosMTG
{
    public class CartaRepository
    {
        public void InserirCarta(
            string nome,
            string tipo,
            string? supertipo,
            string? subtipo,
            string? custoMana,
            int? valorMana,
            int? poder,
            int? vida)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO dbo.TabelaCartas
                (NomeCarta, TipoCarta, SupertipoCarta, SubtipoCarta, CustoMana, ValorMana, PoderCarta, VidaCarta)
                VALUES
                (@Nome, @Tipo, @Super, @Sub, @Custo, @Valor, @Poder, @Vida)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Super", (object?)supertipo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Sub", (object?)subtipo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Custo", (object?)custoMana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Valor", (object?)valorMana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Poder", (object?)poder ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Vida", (object?)vida ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeletarCarta(string nomeCarta)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                DELETE FROM dbo.TabelaCartas
                WHERE nomeCarta = @NomeCarta";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeCarta", nomeCarta);
                cmd.ExecuteNonQuery();
            }
        }
        public void ProcurarPorNome(string nomeCarta)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT *
                FROM dbo.TabelaCartas
                WHERE nomeCarta = @NomeCarta";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeCarta", nomeCarta);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    Console.WriteLine("- Nenhuma carta encontrada com esse nome. -");
                    return;
                }
                while (reader.Read())
                {
                    Console.WriteLine($"= Nome: {reader["NomeCarta"]}, Tipo: {reader["TipoCarta"]}, Supertipo: {reader["SupertipoCarta"]}, Subtipo: {reader["SubtipoCarta"]}, Custo de Mana: {reader["CustoMana"]}, Valor de Mana: {reader["ValorMana"]}, Poder: {reader["PoderCarta"]}, Vida: {reader["VidaCarta"]} -");
                }
            }
        }
        public void ProcurarPorCusto(string custoWUBRG)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT *
                FROM dbo.TabelaCartas
                WHERE CustoMana LIKE '%' + @CustoMana + '%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CustoMana", custoWUBRG);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    Console.WriteLine("- Nenhuma carta encontrada com esse custo. -");
                    return;
                }
                while (reader.Read())
                {
                    Console.WriteLine($"= Nome: {reader["NomeCarta"]}, Tipo: {reader["TipoCarta"]}, Supertipo: {reader["SupertipoCarta"]}, Subtipo: {reader["SubtipoCarta"]}, Custo de Mana: {reader["CustoMana"]}, Valor de Mana: {reader["ValorMana"]}, Poder: {reader["PoderCarta"]}, Vida: {reader["VidaCarta"]} -");
                }
            }
        }
        public void MostrarTodasAsCartas()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT *
                FROM dbo.TabelaCartas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    Console.WriteLine("- Nenhuma carta encontrada na base de dados. -");
                    return;
                }
                while (reader.Read())
                {
                    Console.WriteLine($"= Nome: {reader["NomeCarta"]}, Tipo: {reader["TipoCarta"]}, Supertipo: {reader["SupertipoCarta"]}, Subtipo: {reader["SubtipoCarta"]}, Custo de Mana: {reader["CustoMana"]}, Valor de Mana: {reader["ValorMana"]}, Poder: {reader["PoderCarta"]}, Vida: {reader["VidaCarta"]} -");
                }
            }
        }
    }
}
