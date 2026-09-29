#nullable disable
using System;

class Inimigo{
    string nome; 
    int vida;
    int dano;

    public Inimigo(string nome, int vida, int dano){
        this.nome = nome;
        this.vida = vida;
        this.dano = dano;
    }

    public void Atacar(){
        Console.WriteLine($"{nome} atacou causando {dano} de dano!");
    }
}

class Program
{
    static void Main()
    {
        Inimigo orc = new Inimigo("Orc", 300, 75);
        orc.Atacar();
    }
}