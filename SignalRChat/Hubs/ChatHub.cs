//using Microsoft.AspNetCore.SignalR;
//using System.Threading.Tasks;

//namespace SignalRChat.Hubs
//{
//    public class ChatHub : Hub
//    {
//        public async Task SendMessage(string user, string message)
//        {
//            await Clients.All.SendAsync("ReceiveMessage", user, message);
//        }
//    }
//}

using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToGroup(string userName,string groupName, string message)
        {

            await Clients.Group(groupName).SendAsync("Send", $"{userName}: {message}",userName);
            //to send message others except sender     
            //await Clients.Others.SendAsync("Send", $"{userName}: {message}");

        }
        public Task GetConnectionId(string groupName)
        {

            return Clients.Group(groupName).SendAsync("Get", $"{Context.ConnectionId}");
           
        }
        public async Task AddToGroup(string userName,string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Send", $" {userName}  has joined the group {groupName}",userName);
           
            //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string userName,string groupName)
        {

            //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");

            await Clients.Group(groupName).SendAsync("Send", $"{userName} has left the group {groupName}.",userName);

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

        }
    }
}