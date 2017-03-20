﻿using Rocket.API.Commands;
using Rocket.API.Plugins;
using System;
using Rocket.API.Player;

namespace Rocket.API.Exceptions
{
    public class NoPermissionsForCommandException : Exception
    {
        private IRocketCommand command;
        private IRocketPlayer player;

        public NoPermissionsForCommandException(IRocketPlayer player, IRocketCommand command)
        {
            this.command = command;
            this.player = player;
        }

        public override string Message
        {
            get
            {
                return "The player " + player.DisplayName + " has no permission to execute the command " + command.Name;
            }
        }
    }
}