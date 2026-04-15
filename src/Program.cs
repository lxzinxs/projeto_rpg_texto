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
            Console.WriteLine("Digite o nome do seu personagem:");
            string nome = Console.ReadLine() ?? "Heroi";
            Console.WriteLine("\nBem vindo ao jogo, "+ nome +"!\n");

            bool opcaoValidaPersonagem = false;

            while (opcaoValidaPersonagem == false)
            {


                Console.WriteLine("Escolha a classe do seu personagem: \n[ 1 ] - Guerreiro \n[ 2 ]  - Arqueiro \n[ 3 ] - Mago");
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                if (opcao == 1)
                {
                    Console.WriteLine("\nVocê escolheu a classe Guerreiro!");
                    jogador = new Guerreiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nVocê escolheu a classe Arqueiro!");
                    jogador = new Arqueiro(nome);
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("\nVocê escolheu a classe Mago!");
                    jogador = new Mago(nome);
                    opcaoValidaPersonagem = true;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    opcaoValidaPersonagem = false;
                }
            }

            bool opcaoValidaAcao = false;

            //treinar - aventurar
            while (opcaoValidaAcao == false)
            {
                Console.WriteLine("\nDigite a sua opção: \n[ 1 ] - treinar\n[ 2 ] - aventurar\n[ 3 ] - ir para a dungeon\n[ 4 ] - mostrar nivel");
                int acao = int.Parse(Console.ReadLine() ?? "0");

                if (acao == 1)
                {
                    Console.WriteLine("\nVocê treinou!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 2)
                {
                    Console.WriteLine("\nVocê está aventurando!");
                    opcaoValidaAcao = true;
                }
                else if (acao == 3)
                {
                    Console.WriteLine("\nVocê entrou na dungeon!");
                    Console.WriteLine("\nQual dungeon deseja entrar: \n[ 1 ] - Goblin [recomendado nivel 0+]\n[ 2 ] - Assassino [recomendado nível 25+]\n[ 3 ] - Orc [recomendado nível 50+]");
                    int opcaoDungeon = int.Parse(Console.ReadLine());
                    opcaoValidaAcao = true;

                    if(opcaoDungeon == 1)
                    {
                        if(jogador.vida <= 0)
                        {
                            Console.WriteLine("\nVocê está morto!\nReinicie o jogo!");
                            opcaoValidaPersonagem = false;
                        }
                        spawnar.GerarGoblin(jogador);
                        opcaoValidaAcao = false;
                    }
                    else if(opcaoDungeon == 2)
                    {
                        if(jogador.vida <= 0)
                        {
                            Console.WriteLine("\nVocê está morto!\nReinicie o jogo!");
                            opcaoValidaPersonagem = false;
                        }
                        spawnar.GerarAssassino(jogador);
                        opcaoValidaAcao = false;
                    }
                    else if(opcaoDungeon == 3)
                    {
                        if(jogador.vida <= 0)
                        {
                            Console.WriteLine("\nVocê está morto!\nReinicie o jogo!");
                            opcaoValidaPersonagem = false;
                        }
                        spawnar.GerarOrc(jogador);
                        opcaoValidaAcao = false;
                    }
                }
                else if(acao == 4)
                {
                    Console.WriteLine($"\nSeu nivel atual é: {jogador.nivel}");
                    Console.WriteLine($"\nvida: {jogador.vida:F0} dano: {jogador.danoBase:F0} defesa {jogador.defesa:F0}");
                }
                else
                {
                    Console.WriteLine("\nEscolha uma opção váilida!");
                    opcaoValidaAcao = false;
                }
            }
        }
    }
}