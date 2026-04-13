using personagens;
using monstros;
namespace geradores;

public class Geradores
{
    private Random aleatorio = new Random();

    public void GerarGoblin(Personagem jogador)
    {
        int quantidade = aleatorio.Next(1, 6);
        Console.WriteLine($"Apareceram {quantidade} Goblins!");

        for (int i = 0; i < quantidade; i++)
        {
            Goblin goblin = new Goblin();
            Console.WriteLine($"Inimigo {i + 1}: \t vida {goblin.vida} \t| dano {goblin.danoBase} \t| defesa {goblin.defesa}");

            while (goblin.vida > 0 && jogador.vida > 0)
            {
                jogador.darDano(goblin);
                Console.WriteLine($"{jogador.nome} atacou! Vida do Goblin: {goblin.vida}");
                if(goblin.vida <= 0)
                {
                    Console.WriteLine("Você derrotou esse Goblin!");

                    jogador.XpAtual += 100;
                    Console.WriteLine($"+100 XP garantido. XP Total: {jogador.XpAtual}");

                    if(jogador.XpAtual >= 100)
                    {
                        jogador.SubirNivel();
                        Console.WriteLine($"PARABÉNS {jogador.nome}! VOCÊ SUBIU DE NÍVEL!");
                    }
                    break;
                }

                goblin.darDano(jogador);
                Console.WriteLine($"O Goblin revidou! Sua vida: {jogador.vida}");
                Thread.Sleep(2000);
                if(jogador.vida <= 0)
                {
                    Console.WriteLine("Você fracassou!");
                    return;
                }
            }
        }
    }

    public async Task GerarAssassino(Personagem jogador)
    {
        int quantidade = aleatorio.Next(1, 6);
        Console.WriteLine($"Apareceram {quantidade} Assassinos!");

        for (int i = 0; i < quantidade; i++)
        {
            Assasino assassino = new Assasino();
            Console.WriteLine($"Inimigo {i + 1}: \t vida {assassino.vida} \t| dano {assassino.danoBase} \t| defesa {assassino.defesa}");

            while (assassino.vida > 0 && jogador.vida > 0)
            {
                jogador.darDano(assassino);
                Console.WriteLine($"{jogador.nome} atacou! Vida do Assassino: {assassino.vida}");
                if(assassino.vida <= 0)
                {
                    break;
                }

                assassino.darDano(jogador);
                Console.WriteLine($"O Assassino revidou! Sua vida: {jogador.vida}");
                Thread.Sleep(2000);
                if(jogador.vida <= 0)
                {
                    Console.WriteLine("Você fracassou!");
                    return;
                }
            }
        }
    }

    public void GerarOrc(Personagem jogador)
    {
        int quantidade = aleatorio.Next(1, 6);
        Console.WriteLine($"Apareceram {quantidade} Orcs!");

        for (int i = 0; i < quantidade; i++)
        {
            Orc orc = new Orc();
            Console.WriteLine($"Inimigo {i + 1}: \t vida {orc.vida} \t| dano {orc.danoBase} \t| defesa {orc.defesa}");

            while (orc.vida > 0 && jogador.vida > 0)
            {
                jogador.darDano(orc);
                Console.WriteLine($"{jogador.nome} atacou! Vida do Orc: {orc.vida}");
                if(orc.vida <= 0)
                {
                    break;
                }

                orc.darDano(jogador);
                Console.WriteLine($"O Orc revidou! Sua vida: {jogador.vida}");
                Thread.Sleep(2000);
                if(jogador.vida <= 0)
                {
                    Console.WriteLine("Você fracassou!");
                    return;
                }
            }
        }
    }
}

