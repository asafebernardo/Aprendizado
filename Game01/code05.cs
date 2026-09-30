using System;

Player player = new Player("Arthur", 150, 80);
Inimigo inimigo = new Inimigo("Orc", 120, 30);

player.ReceberDano(40);
inimigo.ReceberDano(70);

Console.WriteLine($"O {player.VerNome()} tem {player.VerVida()} de vida.");
Console.WriteLine($"O {inimigo.VerNome()} tem {inimigo.VerVida()} de vida.");

class Personagem {
    private string nome;
    private int vida;

    public Personagem(string nome, int vida){
        this.nome = nome;
        this.vida = vida;
    }

    public void ReceberDano(int dano){
        vida -= dano;
    }

    public string VerNome(){
        return nome;
    }

    public int VerVida(){
        return vida;
    }
}

class Player : Personagem{
    int mana;

    public Player(string nome, int vida, int mana) : base(nome, vida){
        this.mana = mana;
    }
}

class Inimigo : Personagem{
    int dano;

    public Inimigo(string nome, int vida, int dano) : base(nome, vida){
        this.dano = dano;
    }
}
