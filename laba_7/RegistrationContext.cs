namespace laba_7;
public delegate void ValidationHandler(RegistrationContext ctx);
public class RegistrationContext
{
    private string email = string.Empty;
    private string password = string.Empty;
    private string username = string.Empty;
    private bool isValid;

    public string Email
    {
        get => email;
        set => email = value ?? throw new ArgumentException(EmptyField);
    }

    public string Password
    {
        get => password;
        set => password = value ?? throw new ArgumentException(EmptyField);
    }
    public string Username
    {
        get => username;
        set => username = value ?? throw new ArgumentException(EmptyField);
    }
    public bool IsValid
    {
        get => isValid;
        set => isValid = value;
    }

    public RegistrationContext(string email, string password, string username, bool isValid = true)
    {
        Email = email;
        Password = password;
        Username = username;
        IsValid = isValid;
    }

    private const string EmptyField = "Поле не может быть пустым";
}