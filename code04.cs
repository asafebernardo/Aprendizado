using System;

Player player = new Player("Arthur", 100, 50);
Inimigo inimigo = new Inimigo("Goblin", 80, 20);

player.ReceberDano(30);
inimigo.ReceberDano(30);

Console.WriteLine($"Vida Player: {player.VerVida()}");
Console.WriteLine($"Vida Inimigo: {inimigo.VerVida()}");

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

    public int VerVida(){
        return vida;
    }
}

class Player : Personagem{
    private int mana;
    public Player(string nome, int vida, int mana) : base(nome, vida){
        this.mana = mana;
    }
}

class Inimigo : Personagem{
    private int dano;
    public Inimigo(string nome, int vida, int dano) : base(nome, vida){
        this.dano=dano;
    }
}