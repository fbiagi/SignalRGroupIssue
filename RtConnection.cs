using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRGroupIssue
{
    public class RtConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Groups.Add(connectionId, "GROUP");
        }
    }
}


