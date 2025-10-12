using laba_6_v2.Terrains;

namespace laba_6_v2;

public class Program
{
    public static void Main(string[] args)
    {
        Forest f1 = new Forest();
        Swamp s1 = new Swamp();
        Mountain m1 = new Mountain();
        Road r1 = new Road();
        Plain p1 = new Plain();
        Character Igor = new Character("Игорь", 10);
        MovmentContext test = new MovmentContext(true, false, false);
        Igor.CharacterDescription();
        Igor.Step(test, f1);
        test.HasForestWalker = true;
        test.IsRaining = true;
        Igor.Step(test, r1);
        Igor.Step(test, s1);
        test.IsRaining = false;
        Igor.Rest();
        Igor.CharacterDescription();
    }
}