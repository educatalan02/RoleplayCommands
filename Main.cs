using Rocket.Core.Plugins;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using Logger = Rocket.Core.Logging.Logger;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayCommands
{
    public class Main : RocketPlugin<Configuration>
    {


        public static Main Instance;

        protected override void Load()
        {
            Instance = this;
            Logger.Log("RoleplayCommands loaded correctly by educatalan02#1236");

            Logger.LogWarning("[RoleplayCommands] Discord Support: discord.gg/Q89FmUk");

            
        }

        protected override void Unload()
        {
            Instance = null;
            Logger.Log("RoleplayCommands Unloaded");
        }
    }
}
