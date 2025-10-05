namespace laba_5_v2;

public interface IWarrior
{

    int Strenght {get; set; }
    int Armor {get; set; }

    void Attack(ICharacter target);

}
