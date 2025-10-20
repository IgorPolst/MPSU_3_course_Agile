namespace laba_7;

public class ValidationPipeline
{
    private ValidationHandler? validationHandler;

    public ValidationPipeline()
    {
        validationHandler = null!;
    }
       
    public void AddValidator(ValidationHandler validator)
    {
        validationHandler += validator;
    }

    public void RemoveValidator(ValidationHandler validator)
    {
        validationHandler -= validator;
    }
    public void ClearValidators()
    {
        validationHandler = null;
    }

    public void Run(RegistrationContext ctx)
    {
        validationHandler?.Invoke(ctx);
    }
}