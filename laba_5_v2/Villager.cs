namespace laba_5_v2;

public class Villager: ICharacter
{
    private string name { get; init; } = string.Empty;
    private int health {get; set; }

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

    public Villager(string name, int health)
    {
        Name = name; 
        Health = health;
    }


}
