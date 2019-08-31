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
    public class oocCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "ooc";

        public string Help => Syntax;

        public string Syntax => "/ooc BLABLABLABLA";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>()
        {
            "ooc"
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



                ChatManager.serverSendMessage(Main.Instance.Configuration.Instance.OocFormat.Replace('{', '<').Replace('}', '>').Replace(PlayerVar, PlayerStr).Replace(Text, str), Color.white, null, null, EChatMode.GLOBAL, Main.Instance.Configuration.Instance.OocImgUrl, true);
            


        }
    }
}
