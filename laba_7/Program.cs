namespace laba_7;

public class Program
{
    public static void Main(string[] args)
    {
        var pipeline = new ValidationPipeline();
        pipeline.AddValidator(CheckEmailFormat);
        pipeline.AddValidator(CheckPaswordLength);
        pipeline.AddValidator((RegistrationContext ctx) =>
            {
                if (!char.IsUpper(ctx.Username[0])) { ctx.IsValid = false; }
            }
        );
        
     
        var context1 = new RegistrationContext("test@example.com", "longpassword", "Ivan");
        pipeline.Run(context1);
        Console.WriteLine($"{context1.Username}: {context1.IsValid}");

        var context2 = new RegistrationContext("test@example.com", "longpassword", "ivan");
        pipeline.Run(context2);
        Console.WriteLine($"{context2.Username}: {context2.IsValid}");
        
        var context3 = new RegistrationContext("test@example.com", "longpassword", "marIa");
        pipeline.Run(context3);
        Console.WriteLine($"{context3.Username}: {context3.IsValid}");

        pipeline.RemoveValidator(CheckEmailFormat);

        var context4 = new RegistrationContext("testexample.com", "longpassword", "Dmitry");
        pipeline.Run(context4);
        Console.WriteLine($"{context4.Username}: {context4.IsValid}");
    
    }

    static void CheckEmailFormat(RegistrationContext ctx)
    {
        if (!ctx.Email.Contains("@")) ctx.IsValid = false;
    }

    static void CheckPaswordLength(RegistrationContext ctx)
    {
        if (ctx.Password.Length < 8) ctx.IsValid = false;
    }


}