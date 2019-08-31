using Rocket.API;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RoleplayCommands.Commands
{
    public class doCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "do";

        public string Help => Syntax;

        public string Syntax => "/do BLABLABLABLA";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>()
        {
            "do"
        };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            string str = "";

            foreach (string item in args)
            {
                str += item + " ";




            }
            string PlayerStr = caller.DisplayName;
            string PlayerVar = "!playerName!";
            string Text = "!text!";
            ChatManager.serverSendMessage(Main.Instance.Configuration.Instance.DoFormat.Replace('{', '<').Replace('}', '>').Replace(PlayerVar, PlayerStr).Replace(Text, str), Color.white, null, null, EChatMode.GLOBAL, Main.Instance.Configuration.Instance.DoImgUrl, true);
            


        }
    }
}
