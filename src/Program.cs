using personagens;
using monstros;
namespace jogo;

public class Jogo
{
    public static void Main(string[] args)
    {
        bool JogoRodando = true;

        while (JogoRodando == true)
        {
            Console.WriteLine(@"
██████╗░██████╗░░██████╗░  ░█████╗░░█████╗░██████╗░██╗░░░██╗██╗░░░░░░█████╗░░██████╗░█████╗░
██╔══██╗██╔══██╗██╔════╝░  ██╔══██╗██╔══██╗██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔════╝██╔══██╗
██████╔╝██████╔╝██║░░██╗░  ██║░░╚═╝███████║██████╦╝██║░░░██║██║░░░░░██║░░██║╚█████╗░██║░░██║
██╔══██╗██╔═══╝░██║░░╚██╗  ██║░░██╗██╔══██║██╔══██╗██║░░░██║██║░░░░░██║░░██║░╚═══██╗██║░░██║
██║░░██║██║░░░░░╚██████╔╝  ╚█████╔╝██║░░██║██████╦╝╚██████╔╝███████╗╚█████╔╝██████╔╝╚█████╔╝
╚═╝░░╚═╝╚═╝░░░░░░╚═════╝░  ░╚════╝░╚═╝░░╚═╝╚═════╝░░╚═════╝░╚══════╝░╚════╝░╚═════╝░░╚════╝░");
            Console.Write("Digite o nome do seu personagem: \n");
            string nome = Console.ReadLine() ?? "Heroi";
            Console.Write("\nBem vindo ao jogo, "+ nome +"!\n");

            bool opcaoValidaPersonagem = false;

            while (opcaoValidaPersonagem == false)
            {


                Console.WriteLine("Escolha a classe do seu personagem: \n1 - Guerreiro \n2 - Arqueiro \n3 - Mago");
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                if (opcao == 1)
                {
                    Console.WriteLine("Você escolheu a classe Guerreiro!");
                    Guerreiro guerreiro = new Guerreiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Você escolheu a classe Arqueiro!");
                    Arqueiro arqueiro = new Arqueiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Você escolheu a classe Mago!");
                    Mago mago = new Mago(nome);
                    opcaoValidaPersonagem = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    opcaoValidaPersonagem = false;
                }
            }

            bool opcaoValidaAcao = false;

            //treinar - aventurar
            while (opcaoValidaAcao == false)
            {
                Console.WriteLine("Digite a sua opção: \n1 - treinar\n2 - aventurar\n3 - ir para a dungeon");
                int acao = int.Parse(Console.ReadLine() ?? "0");

                if (acao == 1)
                {
                    Console.Write("Você treinou!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 2)
                {
                    Console.Write("Você está aventurando!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 3)
                {
                    Console.Write("Você entrou na dungeon!");
                    opcaoValidaAcao = true;
                }
                else
                {
                    Console.Write("Escolha uma opção váilida!");
                    opcaoValidaAcao = false;
                }
            }

            Console.ReadKey();
        }
    }
}