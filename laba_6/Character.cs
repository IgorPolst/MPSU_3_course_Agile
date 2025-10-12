namespace laba_6;

public class Character
{
    private string name = string.Empty;
    private int stamina;
    private int maxStamina;
    private string position = string.Empty;

    private MovmentContext movmentContext = new MovmentContext(); 

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentException(
            "Имя не может быть пустым");
    }

    public int Stamina
    {
        get => stamina;
        set => stamina = Math.Clamp(value, 0, maxStamina);
    }

    public int MaxStamina
    {
        get => maxStamina;
        set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Максимальная выносливость должна быть больше 0");
            maxStamina = value;
        }
    }

    public string Position
    {
        get => position;
        set => position = value ?? throw new ArgumentException(
            "Позиция не может быть пустой");
    }

    public MovmentContext MovmentContext
    {
        get => movmentContext;
        set => movmentContext = value;
    }

    public Character(string name, int maxStamina, MovmentContext context)
    {
        Name = name;
        MaxStamina = maxStamina;
        Stamina = maxStamina;
        Position = "Start";
        MovmentContext = context;
    }

    public void Step(TerrainType terrain)
    {
        int cost = MovmentCostCalculatingEnum.CalculateCost(terrain, MovmentContext);
        if (Stamina >= cost)
        {
            Position = MovmentCostCalculatingEnum.GetTerrainDescription(terrain);
            Stamina -= cost;
            Console.WriteLine($"{Name} - попал в {Position}");
            Console.WriteLine($"Выносливость {Stamina}/{MaxStamina}\n");
        }
        else Console.WriteLine("У тебя не хватает сил! Нужно отдохнуть!");
    
    }

    public void Rest()
    {
        Stamina = MaxStamina;
        Console.WriteLine($"{Name} полностью восстановился");
    }

    public void Rest(int staminaAmount)
    {
        if (staminaAmount <= 0)
            throw new ArgumentException(
                "Кол-во для восстановления стамины не должно быть меньше 0");
        Stamina += staminaAmount;
    }
    
    public void UpdateMovmentContext(MovmentContext newContext)
    {
        MovmentContext = newContext ?? MovmentContext;
    }

    public void CharacterDescription()
    {
        Console.WriteLine($"{Name}: позиция: {Position}, выносливость: {Stamina}/{MaxStamina}");
    }
}
