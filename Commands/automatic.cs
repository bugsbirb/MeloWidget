using Melon.Attributes;
using Melon.Models;
using Melon.Services;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Melon.Commands;

[ModuleDisabled]
public class Automatic: ApplicationCommandModule<ApplicationCommandContext>
{
    private Discord _discord = new();
    private Melonly _melon = new();
    private Sqlite _sqlite = new();
    
    [SlashCommand("on", "Automatically refreshes your widget (Very Expensive)")]
    public async Task On([SlashCommandParameter(Description = "Easier, saves you a melonly credit.")] string? melonUser = null)
    {
        ulong userId = Context.Interaction.User.Id;
        string melonId = melonUser ?? string.Empty;
        if (melonUser == null)
        {
            Member? aMelon = await _melon.GetUser(userId);
            if (aMelon == null)
            {
                InteractionMessageProperties response = new()
                {
                    Content = $"` ❌ ` **{Context.Interaction.User.GlobalName},** I was unable to find your Melonly account."
                };
                await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
                return;
            }
            melonId = aMelon.Id;
        }
        await _sqlite.AddToTask(melonId, userId);
        InteractionMessageProperties response1 = new()
        {
            Content = $"` ✅ ` **{Context.Interaction.User.GlobalName},** automatic refresh for your widget has been enabled, it will refresh every 30 minutes."
        };
        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response1));

    }
    
    [SlashCommand("off", "Disables automatic refresh for your widget")]
    public async Task Off()
    {
        await _sqlite.RemoveFromTask(Context.Interaction.User.Id);
        InteractionMessageProperties response = new()
        {
            Content = $"` ✅ ` **{Context.Interaction.User.GlobalName},** automatic refresh for your widget has been disabled, it will no longer fresh."
        };
        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
    }
    
}