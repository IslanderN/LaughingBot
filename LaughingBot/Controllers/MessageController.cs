using LaughingBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;

namespace LaughingBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")] // webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach(var c in commands)
            {
                if (c.Contain(message.Text))
                {
                    c.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}
