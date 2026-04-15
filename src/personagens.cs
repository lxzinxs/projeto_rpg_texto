using monstros;
namespace personagens;

public class Personagem
{
    public Personagem(string nome)
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
    public double NextLevelXp = 100;

    //subir o nivel
    public void SubirNivel()
    {
        XpAtual = XpAtual - NextLevelXp;
        NextLevelXp = NextLevelXp * 1.5;
        danoBase = danoBase * 1.25;
        vida = vida * 1.25;
        defesa = defesa * 1.25;
        nivel = nivel + 1;
        vida = vida + 100;
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
    public Guerreiro(string nome) : base(nome)
    {
        vida = 125;
        danoBase = 8;
        defesa = 15;
    }
}

public class Arqueiro : Personagem
{
    public Arqueiro(string nome) : base(nome)
    {

        vida = 100;
        danoBase = 10;
        defesa = 10;
    }
}

public class Mago : Personagem
{
    public Mago(string nome) : base(nome)
    {
        //atributos
        vida = 80;
        danoBase = 15;
        defesa = 5;
    }
}