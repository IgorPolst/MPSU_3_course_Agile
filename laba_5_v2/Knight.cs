namespace laba_5_v2;

public class Knight: ICharacter, IWarrior
{
    private string name = string.Empty;
    private int health;
    private int strenght;
    private int armor;

    public string Name
    {
        get => name;
        init => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Health
    {
        get => health;
        set => health = Math.Max(0, value);
    }
    
    public int Armor
    {
        get => armor;
        set => armor = Math.Max(0, value);
    }

    public int Strength
    {
        get => strenght;
        set => strenght = Math.Max(0, value);
    }

    public Knight(string name, int health, int strenght, int armor)
    {
        Name = name;
        Health = health;
        Strength = strenght;
        Armor = armor;
    }
    void TakeDamage(int amount)
    {
        int oldHealth = Health;
        if (amount < 0)
            throw new ArgumentException("Урон не может быть отрицательным");

        Health = Math.Max(0, Health - (amount - Armor));
        
        Console.WriteLine($"{Name} получил {amount} урона: {oldHealth} → {Health}");
    }
    public void Attack(ICharacter target)
    {
        target.TakeDamage(Strength);
    }
}
