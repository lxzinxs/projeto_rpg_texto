using System.ComponentModel.DataAnnotations;

public class Personagem
{
    public string nome;
    public int vida;
    public int mana;
    public int forca;
    public int defesa;

    public Aleatorio.(){
        
    }
}

public class Guerreiro : Personagem
{
    public Guerreiro()
    {
        nome = "";
        vida = 100;
        mana = 100;
        forca = 10;
        defesa = 10;
    }
}

public class Arqueiro : Personagem
{
    public Arqueiro()
    {
        nome = "";
        vida = 100;
        mana = 100;
        forca = 10;
        defesa = 10;
    }
}

public class Mago : Personagem
{
    public Mago()
    {
        nome = "";
        vida = 100;
        mana = 100;
        forca = 20;
        defesa = 5;
    }
}

public class Nivel : Personagem
{
    int nivel = 1;
}

public class Dano : Personagem
{
        Random dano = new Random();
        int danoGuerreiro = dano.Next(10, 21);
}

public class Monstro
{
    public int vida;
    public int mana;
    public int forca;
    public int defesa;
}

public class Goblin : Monstro
{
    public Goblin()
    {
        Random aleatorio = new Random();
        int vidaGoblin = aleatorio.Next(9, 101);
        vida = vidaGoblin;
    
        int manaGoblin = aleatorio.Next(9, 101);
        mana = manaGoblin;
    
        int forcaGoblin = aleatorio.Next(9, 101);
        forca = forcaGoblin;
        
        int defesaGoblin = aleatorio.Next(9, 101);
        defesa = defesaGoblin;
    }
}

public class Assasino : Monstro
{
    public Assasino()
    {
        Random aleatorio = new Random();
        int vidaAssasino = aleatorio.Next(49, 149);
        vida = vidaAssasino;
    
        int manaAssasino = aleatorio.Next(9, 101);
        mana = manaAssasino;
    
        int forcaAssasino = aleatorio.Next(9, 101);
        forca = forcaAssasino;
        
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
    
        int manaOrc = aleatorio.Next(149, 301);
        mana = manaOrc;
    
        int forcaOrc = aleatorio.Next(149, 301);
        forca = forcaOrc;
        
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
            Console.Write("Digite o nome do seu personagem: ");
            string nome = Console.ReadLine();
            
            bool opcaoValida = false;

            while (opcaoValida == false)
            {
                Console.WriteLine("Escolha a classe do seu personagem: \n1 - Guerreiro \n2 - Arqueiro \n3 - Mago");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Você escolheu a classe Guerreiro!");
                    Guerreiro guerreiro = new Guerreiro();

                    //treinar
                    Console.WriteLine("deseja treinar? \n1 - Sim \n2 - Não");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        
                    }
                    opcaoValida = true;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Você escolheu a classe Arqueiro!");
                    Arqueiro arqueiro = new Arqueiro();
                    opcaoValida = true;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Você escolheu a classe Mago!");
                    Mago mago = new Mago();
                    opcaoValida = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    opcaoValida = false;
                }
            }
            Goblin a = new Goblin();
            Console.Write($"{a.vida}, {a.mana}, {a.forca}, {a.defesa}\n");
            Assasino b = new Assasino();
            Console.Write($"{b.vida}, {b.mana}, {b.forca}, {b.defesa}\n");
            Orc c = new Orc();
            Console.Write($"{c.vida}, {c.mana}, {c.forca}, {c.defesa}\n");    




            Console.ReadKey();
        }
    }
}