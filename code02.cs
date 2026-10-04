// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public class HelloWorld {

    static int CalcularDano(int ataque, int defesa){
        int dano = ataque - defesa; 
        
        if (dano <= 0){ 
            return 0; 
            } return dano; 
    }
    
    static int ReceberDano(int vida, int dano){ 
        int resultado = vida - dano;
        
        if (resultado <= 0){
            return 0; 
            } return resultado; 
    }

    static int Atacar(int ataque, int defesa, int vida){
        int dano = CalcularDano(ataque, defesa);
        int resultado = ReceberDano(vida, dano);

        return resultado;
    }

    static void MostrarAtaque(string hero , string enemy, int dano, int enemyHP){
        Console.WriteLine($"{hero} ataca!");
        Console.WriteLine($"Dano: {dano}");

        if (enemyHP <= 0){
            enemyHP = 0;
            Console.WriteLine($"{enemy} foi derrotado");
            } 
        
            else {
            Console.WriteLine($"Vida restante do {enemy}: {enemyHP}\n");
            } 
    }

    public static void Main(string[] args) {

    string hero = "Heroi";
    string enemy = "Inimigo";
        
    int heroAttack = 50; 
    int heroDefense = 10; 
    int heroHP = 100; 
        
    int enemyAttack = 30; 
    int enemyDefense = 20; 
    int enemyHP = 100;
        
while (enemyHP > 0 && heroHP > 0){
        int dano = CalcularDano(heroAttack, enemyDefense);
        enemyHP = Atacar(heroAttack, enemyDefense, enemyHP);

        MostrarAtaque(hero , enemy, dano, enemyHP);
        
        if (enemyHP > 0 && heroHP > 0){
            heroHP = Atacar(enemyAttack, heroDefense, heroHP);
            Console.WriteLine("Inimigo ataca!");
            
            if (heroHP <= 0){
            heroHP = 0;
            Console.WriteLine("Heroi foi derrotado");
            }
            Console.WriteLine($"Vida restante do heroi: {heroHP}\n");
        } 
     
}
    }
}