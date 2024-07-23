using Microsoft.AspNetCore.SignalR;

namespace RazorChatInRealTimeNet8.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
