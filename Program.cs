using System;

namespace BancoDadosMTG
{
    internal class Program
    {
        static void Main()
        {
            CartaRepository repo = new CartaRepository();

            repo.InserirCarta(
                "NomeExemplo",
                "TipoExemplo",
                "SupertipoExemplo",
                "SubtipoExemplo",
                "CustoExemplo",
                5, 3, 4
            );

            Console.WriteLine("Carta inserida!");
        }
    }
}
