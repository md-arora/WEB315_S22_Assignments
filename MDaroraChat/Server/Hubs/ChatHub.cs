using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MDaroraChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendTypingToOthers(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }
        public async Task SendAnonMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}