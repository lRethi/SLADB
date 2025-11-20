using System;

namespace BancoDadosMTG
{
    internal class Program
    {
        static void Main()
        {
            string nome;
            string tipo;
            string? tempValue; // jeito muito mirabolante pra lidar com coisa nula
            string? supertipo;
            string? subtipo;
            string? custoMana;
            int? valorMana;
            int? poder;
            int? vida;

            Console.WriteLine("--- Bem vindo ao SLADB, seu sistema de gerenciamento de cartas de Magic The Gathering! ---");
            Console.WriteLine("Com tecnologia de ponta, capaz de armazenar suas preciosas cartas em um banco de dados SQL Server!");
            Console.WriteLine("Para começar, escolha uma das opções abaixo:");

            while (true)
            {
                CartaRepository repo = new CartaRepository();
                Console.WriteLine("|-| 1 - Deleta, 2 - Cria, 3 - Procurar por Nome, 4 - Procurar por Custo, 5 - Mostrar Todas as Cartas, 0 - Sair");
                int escolher = int.Parse(Console.ReadLine());
                switch (escolher)
                {
                    case 1:
                        Console.WriteLine("- Entre com o nome da carta à deletar. -");
                        nome = Console.ReadLine();
                        repo.DeletarCarta(nome);
                        break;
                    case 2:
                        Console.WriteLine("- Entre com o nome da carta. -");
                        nome = Console.ReadLine();
                        Console.WriteLine("- Entre com o tipo da carta. -");
                        tipo = Console.ReadLine();
                        Console.WriteLine("- Entre com o supertipo da carta. -");
                        supertipo = Console.ReadLine();
                        Console.WriteLine("- Entre com o subtipo da carta. -");
                        subtipo = Console.ReadLine();
                        Console.WriteLine("- Entre com o custo de mana da carta. -");
                        custoMana = Console.ReadLine();
                        Console.WriteLine("- Entre com o valor de mana da carta. -");
                        tempValue = Console.ReadLine();
                        valorMana = string.IsNullOrEmpty(tempValue) ? null : int.Parse(tempValue);
                        Console.WriteLine("- Entre com o poder da carta. -");
                        tempValue = Console.ReadLine();
                        poder = string.IsNullOrEmpty(tempValue) ?  null : int.Parse(tempValue);
                        Console.WriteLine("- Entre com a vida da carta. -");
                        tempValue = Console.ReadLine();
                        vida = string.IsNullOrEmpty(tempValue) ? null : int.Parse(tempValue);
                        repo.InserirCarta(
                            nome,
                            tipo,
                            supertipo,
                            subtipo,
                            custoMana,
                            valorMana,
                            poder,
                            vida);
                        break;
                    case 3:
                        Console.WriteLine("- Entre com o nome da carta à procurar. -");
                        nome = Console.ReadLine();
                        repo.ProcurarPorNome(nome);
                        break;
                    case 4:
                        Console.WriteLine("- Entre com o custo de mana à procurar. -");
                        custoMana = Console.ReadLine();
                        repo.ProcurarPorCusto(custoMana);
                        break;
                    case 5:
                        repo.MostrarTodasAsCartas();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("- Opção inválida meu bom senhor(a), tente novamente!. -");
                        break;
                }
            }
        }
    }
}
