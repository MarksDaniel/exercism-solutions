using System;

public class Player
{

    Random random = new Random();
    public int RollDie() => random.Next(1, 19);
    

    public double GenerateSpellStrength() => 100 * random.NextDouble();
}
