# SLADB

*“Um banco de dados IRADO para armazenar cartas do jogo de cartas Magic: The Gathering.”*

## Visão Geral

O SLADB é um projeto em C# que fornece uma solução de banco de dados para armazenar cartas de Magic: The Gathering. Ele inclui classes de repositório, contexto de banco de dados e scripts SQL para criação/consulta.
Ele pode ser útil para:

* Quem quer montar uma coleção de cartas em formato digital.
* Desenvolver ferramentas de consulta, filtragem, relatórios ou análises sobre cartas de MTG.
* Servir como base para integrar com outras aplicações (deck builders, simuladores, apps web) que precisam de armazenamento de cartas.

## Funcionalidades Principais

* Estrutura de banco de dados (arquivo `Database.cs`, projeto SQL `PROJETOANDERYFODADEVERDADE.sqlproj`) para armazenar as cartas.
* Repositório de cartas (`CartaRepository.cs`) com métodos de acesso a dados.
* Projeto C# (`CodigoDBMTG.csproj`) que faz a ligação entre o código e o banco de dados.
* Script SQL (`SqlQuery_1.sql`) para talvez criar ou consultar dados.
* Licença MIT — livre para uso, modificação e distribuição.

## Tecnologias e Requisitos

* Linguagem: C# (.NET) — todo o código está em C#. ([GitHub][1])
* Banco de dados: SQL Server ou outra que suporte os scripts SQL (o `.sqlproj` sugere uso de projeto SQL).
* Sistema de desenvolvimento: Visual Studio (arquivo `.sln` presente).
* Licença: MIT. ([GitHub][1])

## Como Começar

1. Clone o repositório:

   ```bash
   git clone https://github.com/lRethi/SLADB.git
   ```
2. Abra o arquivo `PROJETOANDERYFODADEVERDADE.sln` no Visual Studio (ou equivalente).
3. Configure o banco de dados: execute os scripts SQL para criar as tabelas necessárias (ver `PROJETOANDERYFODADEVERDADE.sqlproj` e `SqlQuery_1.sql`).
4. Ajuste a string de conexão no `Database.cs` conforme o seu servidor de banco.
5. Compile e execute o projeto C# para verificar o funcionamento do repositório de cartas.
6. A partir desse ponto, você pode:

   * Inserir dados de cartas manualmente ou por importação.
   * Criar consultas customizadas.
   * Adaptar ou estender a estrutura conforme suas necessidades.

## Estrutura de Pastas/Arquivos

* `CartaRepository.cs` — implementação do repositório de acesso às cartas.
* `Database.cs` — configuração do contexto de banco de dados.
* `CodigoDBMTG.csproj` — projeto C# principal.
* `PROJETOANDERYFODADEVERDADE.sln` — solução que agrupa os projetos.
* `PROJETOANDERYFODADEVERDADE.sqlproj` — projeto de banco de dados SQL.
* `SqlQuery_1.sql` — script de consulta ou criação.
* `.gitignore` / `.gitattributes` — arquivos de configuração do Git.
* `LICENSE.txt` — licença MIT.

## Contribuindo

Contribuições são bem-vindas! Se você quiser ajudar:

* Abra uma *issue* para propor melhorias ou relatar bugs.
* Faça um *fork* do repositório e crie uma branch para suas mudanças.
* Submeta um *pull request* explicando claramente o que foi modificado.
* Mantenha o padrão de código consistente com o existente.
* Verifique se novas funcionalidades possuem teste ou documentação (se aplicável).

## Ideias de Extensão

Aqui vão algumas ideias de funcionalidade que poderiam ser adicionadas:

* Bulk import a partir de arquivos CSV/JSON contendo dados de cartas.
* Interface gráfica (desktop ou web) para navegar, filtrar e visualizar cartas.
* Exportar decklists ou relatórios em PDF/Excel.
* Sincronização com APIs externas de Magic para manter dados atualizados.
* Suporte a imagens das cartas, gráficos de raridade/power/tipo.
* Cache ou indexação para consultas mais rápidas em bases maiores.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja `LICENSE.txt` para mais detalhes.
