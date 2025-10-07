namespace laba_5D;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ СИСТЕМЫ УВЕДОМЛЕНИЙ ===\n");

        var plainNotification = new PlainNotification(
            "Простое уведомление без лимитов");
        var throttledNotification = new ThrottledNotification(
            "Уведомление с лимитом 3 в минуту", 3);

        Console.WriteLine("1. Тест PlainNotification:");
        plainNotification.Send();
        Console.WriteLine($"Статус отправки: {plainNotification.Sent}\n");

        Console.WriteLine("2. Тест ThrottledNotification (лимит 3/минуту):");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\nПопытка {i}:");
            throttledNotification.Send();

            if (i == 3)
            {
                Console.WriteLine("\n--- Достигнут лимит, следующие попытки должны быть отклонены ---");
            }
        }
        
        Console.WriteLine("\n3. Тест сброса лимита:");
        throttledNotification.ResetWindow();

        Console.WriteLine("\nПопытка отправки после сброса:");
        throttledNotification.Send();
        Console.WriteLine($"Статус отправки: {throttledNotification.Sent}");
        
        Console.WriteLine("\n4. Тест прямого использования TryConsume:");
        var testNotification = new ThrottledNotification("Тестовое", 2);

        Console.WriteLine($"Попытка 1: {testNotification.TryConsume()}");
        Console.WriteLine($"Попытка 2: {testNotification.TryConsume()}");
        Console.WriteLine($"Попытка 3: {testNotification.TryConsume()} (должно быть false)");
        Console.WriteLine($"Использовано: {testNotification.UsedInCurrentMinute}/2");
        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ ЗАВЕРШЕНО ===");
    }
}