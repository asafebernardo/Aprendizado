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

    public static void Main(string[] args) {

    int heroAttack = 50; 
    int heroDefense = 10; 
    int heroHP = 100; 
        
    int enemyAttack = 30; 
    int enemyDefense = 20; 
    int enemyHP = 100;
        
while (enemyHP > 0 && heroHP > 0){
    if (heroHP > 0 && enemyHP > 0){
        int dano = CalcularDano(heroAttack, enemyDefense);
        int vidaEnemy = ReceberDano(enemyHP, dano);
        enemyHP = vidaEnemy;
        Console.WriteLine("Heroi ataca!");
        Console.WriteLine($"Dano causado: {dano}");
        if (enemyHP <= 0){
            enemyHP = 0;
            Console.WriteLine("Inimigo foi derrotado");
            } else {
            Console.WriteLine($"Vida restante do inimigo: {enemyHP}\n");
            }
        
        if (vidaEnemy > 0 && heroHP > 0){
            int dano2 = CalcularDano(enemyAttack, heroDefense);
            int vidaHeroi = ReceberDano(heroHP, dano2);
            heroHP = vidaHeroi;
            Console.WriteLine("Inimigo ataca!");
            Console.WriteLine($"Dano causado: {dano2}");
            if (vidaHeroi <= 0){
            vidaHeroi = 0;
            Console.WriteLine("Heroi foi derrotado");
            }
            Console.WriteLine($"Vida restante do heroi: {vidaHeroi}\n");
        } 
    } 
}
    }
}