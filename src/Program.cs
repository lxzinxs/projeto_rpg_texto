public class Personagem
{
    Personagem(string nome)
    {
        this.nome = nome;
    }
    //atributos
    public string nome;
    public double vida;
    public double danoBase;
    public double defesa;
    public double nivel = 1;
    public double XpAtual = 0;
    double NextLevelXp = 100;

    //subir o nivel
    public void SubirNivel()
    {
        XpAtual = XpAtual - NextLevelXp;
        NextLevelXp = NextLevelXp * 1.015;
        danoBase = danoBase * 1.25;
        vida = vida * 1.25;
        defesa = defesa * 1.25;
        nivel = nivel + 1;
    }

    //elevar forca conforme o nivel
    public double XpNextForca()
    {
        nivel = nivel * 1.015;
        return nivel;
    }

    //dar dano no monstro
    public void darDano(Monstro inimigo)
    {
        Random aleatorio = new Random();
        int danoCausado = aleatorio.Next((int)danoBase, (int)(danoBase * 2));
        inimigo.recebeDano(danoCausado);
    }

    //receber dano do monstro
    public void recebeDano(int dano)
    {
        vida = vida - dano;
    }
}

public class Guerreiro : Personagem
{
    public Guerreiro()
    {
        nome = "";
        vida = 125;
        danoBase = 8;
        defesa = 15;
    }
}

public class Arqueiro : Personagem
{
    public Arqueiro()
    {
        nome = "";
        vida = 100;
        danoBase = 10;
        defesa = 10;
    }
}

public class Mago : Personagem
{
    public Mago()
    {
        //atributos
        nome = "";
        vida = 80;
        danoBase = 15;
        defesa = 5;
    }
}

public class Monstro
{
    //variaveis
    public int vida;
    public int danoBase;
    public int defesa;

    //dar dano no player
    public void darDano(Personagem inimigo)
    {   
        Random aleatorio = new Random();
        int danoCausado = danoBase;
        inimigo.recebeDano(danoCausado);
    }

    //receber dano do player
    public void recebeDano(int dano)
    {
        vida = vida - dano;
    }
}

public class Goblin : Monstro
{
    public Goblin()
    {
        Random aleatorio = new Random();
        int vidaGoblin = 150;
        vida = vidaGoblin;

        danoBase = 10;

        int defesaGoblin = aleatorio.Next(9, 11);
        defesa = defesaGoblin;
    }
}

public class Assasino : Monstro
{
    public Assasino()
    {
        Random aleatorio = new Random();
        int vidaAssasino = aleatorio.Next(49, 151);
        vida = vidaAssasino;

        int forcaAssasino = aleatorio.Next(9, 101);
        danoBase = forcaAssasino;

        int defesaAssasino = aleatorio.Next(9, 101);
        defesa = defesaAssasino;
    }
}

public class Orc : Monstro
{
    public Orc()
    {
        Random aleatorio = new Random();
        int vidaOrc = aleatorio.Next(149, 301);
        vida = vidaOrc;

        int forcaOrc = aleatorio.Next(149, 301);
        danoBase = forcaOrc;

        int defesaOrc = aleatorio.Next(149, 301);
        defesa = defesaOrc;
    }
}

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
            Console.Write("Digite o nome do seu personagem: ");
            string nome = Console.ReadLine();

            bool opcaoValidaPersonagem = false;

            while (opcaoValidaPersonagem == false)
            {


                Console.WriteLine("Escolha a classe do seu personagem: \n1 - Guerreiro \n2 - Arqueiro \n3 - Mago");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Você escolheu a classe Guerreiro!");
                    Guerreiro guerreiro = new Guerreiro();
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Você escolheu a classe Arqueiro!");
                    Arqueiro arqueiro = new Arqueiro();
                    opcaoValidaPersonagem = true;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Você escolheu a classe Mago!");
                    Mago mago = new Mago();
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
                int acao = int.Parse(Console.ReadLine());

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