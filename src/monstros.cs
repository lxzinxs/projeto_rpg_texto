using personagens;
namespace monstros;

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