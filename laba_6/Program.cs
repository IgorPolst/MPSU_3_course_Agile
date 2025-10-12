using System.Threading.Channels;

namespace laba_6;

class Program
{
    static void Main(string[] args)
    {

        MovmentContext forIgor = new MovmentContext(true, false, false);
        Character igor = new Character(
            "Игорь", 5, forIgor);

        igor.CharacterDescription();
        igor.Step(TerrainType.Forest);
        igor.Step(TerrainType.Road);
        igor.Step(TerrainType.Mountain);
        igor.Rest();
        igor.Step(TerrainType.Mountain);
        forIgor.IsMountainBreed = true;
        igor.UpdateMovmentContext(forIgor);
        igor.Rest();
        igor.Step(TerrainType.Mountain);
        igor.CharacterDescription();
        
    }
            
}