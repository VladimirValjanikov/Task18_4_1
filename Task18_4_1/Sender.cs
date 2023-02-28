using System;
using System.Collections.Generic;
namespace Task18_4_1
{
    public class Sender
    {
        CommandOne commandOne;

        public void SetCommand(CommandOne commandOne)
        {
            this.commandOne = commandOne;
        }

        public void Download(string url, string place)
        {
            commandOne.Download(url, place);
        }

        public void Info(string url)
        {
            commandOne.Info(url);
        }
    }
}
