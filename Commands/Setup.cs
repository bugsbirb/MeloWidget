using DotNetEnv;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Melon.Commands;

public class Setup: ApplicationCommandModule<ApplicationCommandContext>
{
    private readonly string _botId = Env.GetString("BOTID") ?? string.Empty;
    
    [SlashCommand("setup", "Setups the Melonly widget.")]
    public async Task SetupWidget()
    {
        ActionRowProperties components = new()
        {
            new LinkButtonProperties($"https://discord.com/oauth2/authorize?client_id={_botId}&response_type=token&scope=openid+sdk.social_layer", "Authorise")
        };
        InteractionMessageProperties response = new()
        {
            Content = $"To continue, authorise with the application using the button below.\n\n-# Authorising will not edit this message, so as soon as you are done, run `/refresh.`",
            Components = [components]
        };
        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
    }
    
}