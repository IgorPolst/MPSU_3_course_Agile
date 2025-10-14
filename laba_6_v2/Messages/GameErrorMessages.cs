namespace laba_6_v2.Messages;

public static class GameErrorMessages
{
    // Общие ошибки валидации
    public const string InvalidName = "Имя персонажа не может быть пустым";
    public const string InvalidMaxStamina = "Максимальная выносливость должна быть больше 0";

    // Ошибки контекста
    public const string NullContext = "Контекст перемещения не может быть null";

    // Предупреждения
    public const string LowStaminaWarning = "У тебя не хватает сил! Нужно отдохнуть!";
    public const string InvalidStaminaRest = "Извини, но разве это отдых?";
}

