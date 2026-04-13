using personagens;
using monstros;
using geradores;
namespace jogo;

public class Jogo
{
    public static void Main(string[] args)
    {
        //gerar monstros
        Geradores spawnar = new Geradores();

        //nao dar erro (atacar ou inventario(C# é chato com isso), pois a depois do if a classe desaparece - (ficou uma merda de entender kkkkkkk) - (me pergunta no zap dps)
        Personagem jogador = null; 

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
            Console.WriteLine("\nBem vindo ao jogo, "+ nome +"!\n");

            bool opcaoValidaPersonagem = false;

            while (opcaoValidaPersonagem == false)
            {


                Console.WriteLine("Escolha a classe do seu personagem: \n1 - Guerreiro \n2 - Arqueiro \n3 - Mago");
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                if (opcao == 1)
                {
                    Console.WriteLine("Você escolheu a classe Guerreiro!");
                    jogador = new Guerreiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Você escolheu a classe Arqueiro!");
                    jogador = new Arqueiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Você escolheu a classe Mago!");
                    jogador = new Mago(nome);
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
                    Console.WriteLine("Você treinou!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 2)
                {
                    Console.WriteLine("Você está aventurando!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 3)
                {
                    Console.WriteLine("Você entrou na dungeon!");
                    Console.WriteLine("Deseja qual dungeon deseja entrar: \n1 - Goblin [recomendado nivel 0]\n2 - Assassino [recomendado nível 25]\n3 - Orc [recomendado nível 50+]");
                    int opcaoDungeon = int.Parse(Console.ReadLine());
                    opcaoValidaAcao = true;

                    if(opcaoDungeon == 1)
                    {
                        spawnar.GerarGoblin(jogador);
                    }
                    else if(opcaoDungeon == 2)
                    {
                        spawnar.GerarAssassino(jogador);
                    }
                    else if(opcaoDungeon == 3)
                    {
                        spawnar.GerarOrc(jogador);
                    }
                }
                else
                {
                    Console.WriteLine("Escolha uma opção váilida!");
                    opcaoValidaAcao = false;
                }
            }

            Console.ReadKey();
        }
    }
}