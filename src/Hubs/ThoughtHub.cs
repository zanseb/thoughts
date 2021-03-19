using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace thoughts.app.Hubs
{
    public class ThoughtHub : Hub
    {
        public const string HubUrl = "/thought";

        public async Task Share(string thought)
        {
            await Clients.All.SendAsync("Share", thought);
        }
    }
}
