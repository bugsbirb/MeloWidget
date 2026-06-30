using DotNetEnv;
using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Melon.Commands;

public class Setup: ApplicationCommandModule<ApplicationCommandContext>
{
    private string _botId = Env.GetString("BOTID") ?? string.Empty;
    
    [SlashCommand("setup", "Setups the Melonly widget.")]
    public async Task SetupWidget()
    {
        ActionRowProperties components = new()
        {
            new LinkButtonProperties($"https://discord.com/oauth2/authorize?client_id={_botId}&response_type=code&scope=openid+sdk.social_layer", "Authorise")
        };
        InteractionMessageProperties response = new()
        {
            Content = $"Please authorise with the application using the button below.\nThere are a large amount of permissions it's asking for, but don't worry, we aren't storing the token.\nThis is just a side effect of Discord's Social SDK bizarre requirements.\n\nAuthorising will not edit this message, so as soon as you are done, run /refresh.",
            Components = [components]
        };
        await Context.Interaction.SendResponseAsync(InteractionCallback.Message(response));
    }
    
}