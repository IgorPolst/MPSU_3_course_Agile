namespace laba_5_v2;

public interface IWarrior
{

    int Strength {get; }
    int Armor {get; }

    void Attack(ICharacter target);

}
