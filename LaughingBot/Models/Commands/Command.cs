using Telegram.Bot;
using Telegram.Bot.Types;

namespace LaughingBot.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contain(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }
    }
}