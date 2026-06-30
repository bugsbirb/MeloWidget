using System.ComponentModel;
using System.Text.Json;
using Melon.Models;
using Melon.Services;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Melon.Commands;

public class Refresh: ApplicationCommandModule<ApplicationCommandContext>
{
    private Discord _discord = new();
    private Melonly _melon = new();

    [SlashCommand("refresh", "Refreshes the Melonly widget. (Expensive for api credits)")]
    public async Task RefreshCommand([SlashCommandParameter(Description = "Easier, saves you a melonly credit.")] string? melonUser = null)
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


        object? dynamicData = await _discord.DynamicData(melonId);
        if (dynamicData == null)
        {
            InteractionMessageProperties response = new()
            {
                Content = "` ❌ ` For whatever reason, it doesn't be appearing to work. (Dynamic Data)"
            };
            await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
            return;
        }
        
        bool result = await _discord.Call(userId, dynamicData);
        if (!result)
        {
            InteractionMessageProperties response = new()
            {
                Content = "` ❌ ` For whatever reason, it doesn't be appearing to work. (Data Call)"
            };
            await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
            return;
        }
        
        InteractionMessageProperties fresponse = new()
        {
            Content = $"` ❌ ` **{Context.User.GlobalName},** your Melonly information has been synced to your widget."
        };
        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(fresponse));

    }
    
}