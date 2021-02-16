using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoInicial();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        TelaSerie.Series();
                        break;
                    case "2":
                        TelaFilmes.Filmes();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcaoInicial();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine(); 
        }
        public static string OpcaoInicial()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filmes");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
