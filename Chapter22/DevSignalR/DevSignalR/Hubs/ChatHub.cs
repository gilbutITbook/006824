using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DevSignalR.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        /// <summary>
        /// C -> S
        /// 클라이언트에서 서버로 간단한 메시지(msg) 전송
        /// </summary>
        /// <param name="msg"></param>
        public void ClientToServer(string msg)
        {
            // S -> Cs
            Clients.All.serverToClient(msg);
        }
    }
}
