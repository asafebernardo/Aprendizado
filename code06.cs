using System;
using System.Collections.Generic;

Inimigo inimigo1 = new Orc();
Inimigo inimigo2 = new Goblin();
Inimigo inimigo3 = new Dragao();

List<Inimigo> inimigos = new List<Inimigo>();

inimigos.Add(inimigo1);
inimigos.Add(inimigo2);
inimigos.Add(inimigo3);

foreach (Inimigo i in inimigos){
    i.Atacar();
}


public class Inimigo{
    public virtual void Atacar(){
        Console.WriteLine("Inimigo ataca!");
    }
}

public class Orc : Inimigo{
    public override void Atacar(){
        Console.WriteLine("Orc ataca!");
    }    
}

public class Goblin : Inimigo{
    public override void Atacar(){
        Console.WriteLine("Goblin ataca!");
    }    
}

public class Dragao : Inimigo{
    public override void Atacar(){
        Console.WriteLine("Dragao ataca!");
    }    
}