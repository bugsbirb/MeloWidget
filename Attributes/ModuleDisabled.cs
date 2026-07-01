using DotNetEnv;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;

namespace Melon.Attributes;

public class ModuleDisabled : PreconditionAttribute<ApplicationCommandContext>
{
    public override ValueTask<PreconditionResult> EnsureCanExecuteAsync(ApplicationCommandContext context, IServiceProvider? serviceProvider)
    {
        bool isEnabled = Env.GetBool("AUTOMATIC_REFRESH", false);
        if (!isEnabled)
        {
            return new(PreconditionResult.Fail("You've disabled tasks"));
        } 
        return new(PreconditionResult.Success);
    }
}