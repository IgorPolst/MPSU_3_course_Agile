namespace laba_5_v2;

public interface ICharacter
{
    string Name { get; init; }
    int Health { get; set; }
    void TakeDamage(int amount)
    {
        int oldHealth = Health;
        if (amount < 0)
            throw new ArgumentException("Урон не может быть отрицательным");

        Health = Math.Max(0, Health - amount);

        Console.WriteLine($"{Name} получил {amount} урона: {oldHealth} → {Health}");
    }
    
    
}
