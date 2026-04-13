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

        int defesaGoblin = aleatorio.Next(9, 16);
        defesa = defesaGoblin;
    }
}

public class Assasino : Monstro
{
    public Assasino()
    {
        Random aleatorio = new Random();
        int vidaAssassino = 300;
        vida = vidaAssassino;

        danoBase = 30;

        int defesaAssassino = aleatorio.Next(25, 51);
        defesa = defesaAssassino;
    }
}

public class Orc : Monstro
{
    public Orc()
    {
        Random aleatorio = new Random();
        int vidaOrc = 500;
        vida = vidaOrc;

        danoBase = 50;

        int defesaOrc = aleatorio.Next(50, 76);
        defesa = defesaOrc;
    }
}