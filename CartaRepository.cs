using System.Data.SqlClient;

namespace BancoDadosMTG
{
    public class CartaRepository
    {
        public void InserirCarta(
            string nome,
            string tipo,
            string supertipo,
            string subtipo,
            string custoMana,
            int valorMana,
            int poder,
            int vida)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO dbo.Table
                (NomeCarta, TipoCarta, SupertipoCarta, SubtipoCarta, CustoMana, ValorMana, PoderCarta, VidaCarta)
                VALUES
                (@Nome, @Tipo, @Super, @Sub, @Custo, @Valor, @Poder, @Vida)
            ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Super", supertipo);
                cmd.Parameters.AddWithValue("@Sub", subtipo);
                cmd.Parameters.AddWithValue("@Custo", custoMana);
                cmd.Parameters.AddWithValue("@Valor", valorMana);
                cmd.Parameters.AddWithValue("@Poder", poder);
                cmd.Parameters.AddWithValue("@Vida", vida);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
