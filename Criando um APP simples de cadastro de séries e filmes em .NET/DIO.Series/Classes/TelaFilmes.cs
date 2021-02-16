using System;
namespace DIO.Series
{
    public static class TelaFilmes
    {
        static FilmeRepositorio filmeRepositorio = new FilmeRepositorio();
        public static void Filmes()
        {
            string opcaoUsuario = ObterOpcaoUsuarioFilme();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilmes();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        VisualizarFilme();
                        break;
                    case "5":
                        AlugarFilme();
                        break;
                    case "6":
                        ExcluirFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuarioFilme();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }


        private static void ListarFilmes()
        {
            System.Console.WriteLine("     Filmes:     ");
            var lista = filmeRepositorio.Lista();
            if (lista.Count == 0)
            {
                System.Console.WriteLine("Não tem filmes cadastrados");
                return;
            }
            foreach (var filme in lista)
            {
                var alugado = filme.VerificarDisponibilidade();
                var excluido = filme.RetornaExcluido();
                if (!excluido)
                {
                    System.Console.WriteLine("#ID {0} - {1} {2}", filme.RetornaId(), filme.RetornaTitulo(), alugado ? "*Disponivel*":"*Alugado*");
                }
            }
        }
        private static void InserirFilme()
        {
            System.Console.WriteLine("Inserir novo Filme:");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme filme = new Filme(id: filmeRepositorio.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno);
            filmeRepositorio.Insere(filme);
        }
        private static void AtualizarFilme()
        {
            System.Console.WriteLine("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero do Filme: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme filme = new Filme(id: indiceFilme,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno);
            filmeRepositorio.Atualiza(indiceFilme, filme);
        }
        private static void AlugarFilme()
        {
            System.Console.WriteLine("Digite o id da Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            filmeRepositorio.Alugar(indiceFilme);
        }
        private static void VisualizarFilme()
        {
            System.Console.WriteLine("Digite o id da Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = filmeRepositorio.RetornaPorId(indiceFilme);
            System.Console.WriteLine(filme);
        }
        private static void ExcluirFilme()
        {
            System.Console.WriteLine("Digite o id do Filme para alugar o mesmo: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            filmeRepositorio.Exclui(indiceFilme);
        }

        public static string ObterOpcaoUsuarioFilme()
        {
            Console.WriteLine();
            Console.WriteLine("      Filmes:      ");

            Console.WriteLine("1 - Listar Filmes");
            Console.WriteLine("2 - Inserir nono Filme");
            Console.WriteLine("3 - Atualizar Filme");
            Console.WriteLine("4 - Visualizar Filme");
            Console.WriteLine("5 - Visualizar Filme");
            Console.WriteLine("6 - Excluir Filme");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }

}