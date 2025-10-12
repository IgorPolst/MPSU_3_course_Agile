
namespace laba_6_v2;

public class MovmentContext
{
    private bool hasForestWalker { get; set; }
    private bool isRaining { get; set; }
    private bool isMountainBreed { get; set; }

    public bool HasForestWalker
    {
        get => hasForestWalker;
        set
        {
            NotifyForestChange(value);
            hasForestWalker = value;
        }
    }

    public bool IsRaining
    {
        get => isRaining;
        set
        {
            ToggleRain(value);
            isRaining = value;
        }
    }
    public bool IsMountainBreed
    {
        get => isMountainBreed;
        set
        {
            NotifyMountainChange(value);
            isMountainBreed = value;
        }
    }
    public MovmentContext()
    {

    }

    public MovmentContext(bool hasForestWalker, bool isRaining, bool isMountainBreed)
    {
        HasForestWalker = hasForestWalker;
        IsRaining = isRaining;
        IsMountainBreed = isMountainBreed;
    }
    private void NotifyForestChange(bool selector)
    {
        Console.WriteLine(selector
            ? "Теперь вы лучше ориентируетесь в лесу"
            : "Вы забыли как ориентироваться в лесу");
    }
    private void ToggleRain(bool selector)
    {
        Console.WriteLine(selector
            ? "Начался дождь"
            : "Тучи на небе разошлись");
    }
    private void NotifyMountainChange(bool selector)
    {
        Console.WriteLine(selector
            ? "Теперь вы лучше лазаете по горам"
            : "Вы забыли как лазать по горам");
    }   
    public void MovmentContextDescription()
    {
        string conditions = string.Empty;
        if (HasForestWalker) conditions += "Лесной путник";
        if (IsRaining) conditions += " Дождь";
        if (IsMountainBreed) conditions += " Горец";

        Console.WriteLine(conditions);
    }

}