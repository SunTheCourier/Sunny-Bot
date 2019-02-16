﻿using System.Threading.Tasks;
using Discord.Commands;

namespace Sombra_Bot.Commands
{
    public class Message : ModuleBase<SocketCommandContext>
    {
        [Command("Say"), Summary("Says the message sent.")]
        [RequireOwner]
        public async Task Say(params string[] input)
        {
            try
            {
                await Context.Message.DeleteAsync();
            }
            catch { }
            await Context.Channel.SendMessageAsync(string.Join(" ", input));
        }
    }
}
