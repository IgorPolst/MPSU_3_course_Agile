using System.ComponentModel;
using System.Data;

namespace problem_7;

public delegate void RuleHandler(StoreContext context);
public class ScoringPipline
{
    private RuleHandler? ruleHandler;

    public ScoringPipline()
    {
        ruleHandler = null!;
    }

    public void AddRule(RuleHandler rule)
    {
        ruleHandler += rule;
    }

    public void RemoveRule(RuleHandler rule)
    {
        ruleHandler -= rule;
    }

    public void ClearValidators()
    {
        ruleHandler = null;
    }
    
    public void Run(StoreContext context)
    {
        ruleHandler?.Invoke(context);
    }
}