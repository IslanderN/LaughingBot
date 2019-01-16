using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace LaughingBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic

            await client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}