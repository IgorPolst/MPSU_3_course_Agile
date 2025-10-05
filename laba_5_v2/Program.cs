namespace laba_5_v2;

public class Program
{
    public static void Main(string[] args)
    {
        Villager vil1 = new Villager("Игорь", 100);
        Knight kni1 = new Knight("Дмитрий", 150, 25, 15);
        Knight kni2 = new Knight("Александр", 120, 30, 10);

        Console.WriteLine("=== Начало симуляции ===");
        DisplayCharacters(vil1, kni1, kni2);

        Console.WriteLine("\n=== Бой ===");
        kni1.Attack(kni2); 
        kni2.Attack(kni1); 
        kni1.Attack(vil1); 

        Console.WriteLine("\n=== Итоги ===");
        DisplayCharacters(vil1, kni1, kni2);
    }

    private static void DisplayCharacters(params ICharacter[] characters)
    {
        foreach (var character in characters)
        {
            string status = character.Health > 0 ? "жив" : "мертв";
            Console.WriteLine($"{character.Name}: {character.Health} HP ({status})");
        }
    }
}