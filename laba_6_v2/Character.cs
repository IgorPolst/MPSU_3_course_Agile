
namespace laba_6_v2;

using static Messages.GameErrorMessages;
using static Messages.GameSuccessMessages;

public class Character
{
    private string name = string.Empty;
    private int stamina;
    private int maxStamina;
    private string position = string.Empty;

    public string Name
    {
        get => name;
        set => name = value ??
            throw new ArgumentException(InvalidName);
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

    public Character(string name, int maxStamina)
    {
        Name = name;
        MaxStamina = maxStamina;
        Stamina = maxStamina;
        Position = "Start";
    }

    public void Step(MovmentContext context, Terrain terrain)
    {
        int cost = MovementCostCalculatingOop.CalculateCost(context, terrain);
        if (Stamina >= cost)
        {
            Position = terrain.Name;
            Stamina -= cost;
               
            Console.WriteLine(string.Format(MoveSuccess,
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

    public void CharacterDescription()
    {
        Console.WriteLine(string.Format(CharacterDescriptionFormat,
            Name, Position, Stamina, MaxStamina
        ));
    }
}
