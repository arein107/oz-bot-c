﻿using Discord.Commands;

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzBot.Modules
{
   public class Ping : ModuleBase<SocketCommandContext>
    {

        [Command("hello")]

        public async Task PingAsync()
        {
            await ReplyAsync("Heya!");
        }
    }
}
