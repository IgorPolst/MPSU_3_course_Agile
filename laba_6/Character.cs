namespace laba_6;

using static Messages.GameErrorMessages;
using static Messages.GameSuccessMessages;

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
        set => name = value ?? throw new ArgumentException(InvalidName);
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
                throw new ArgumentException(InvalidMaxStamina);
            maxStamina = value;
        }
    }

    public string Position
    {
        get => position;
        set => position = value ??
            throw new ArgumentException(NullContext);
    }

    public MovmentContext MovmentContext
    {
        get => movmentContext;
        set => movmentContext = value ??
            throw new ArgumentException(InvalidContext);
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
            Console.WriteLine(String.Format(MoveSuccess,
                Name, Position, cost, Stamina));

        }
        else Console.WriteLine(LowStaminaWarning);

    }

    public void Rest()
    {
        Stamina = MaxStamina;
        Console.WriteLine(RestSuccess);
    }

    public void Rest(int staminaAmount)
    {
        if (staminaAmount <= 0)
            throw new ArgumentException(InvalidStaminaRest);
        Stamina += staminaAmount;
    }

    public void UpdateMovmentContext(MovmentContext newContext)
    {
        MovmentContext = newContext ?? MovmentContext;
    }

    public void CharacterDescription()
    {
        Console.WriteLine(string.Format(CharacterDescriptionFormat,
            Name, Position, Stamina, MaxStamina));
    }
}
