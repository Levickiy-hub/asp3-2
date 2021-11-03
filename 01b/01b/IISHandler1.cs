using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace _01b
{
    public class IISHandler1 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        WebSocket socket;
        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
                context.AcceptWebSocketRequest(WebSocketRequest);
        }
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket;
            string s = await Recieve();
            await Send(s);
            while (socket.State == WebSocketState.Open)
            {
                Thread.Sleep(2000);
                await Send($"server time: " + DateTime.Now.ToString());
            }
        }

        private async Task<string> Recieve()
        {
            string rc = null;
            var buffer = new ArraySegment<byte>(new byte[512]);
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None); 
            rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count); 
            return rc;
        }
        private async Task Send(string s)
        {
            var sendBuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes($"Response: {s}"));
            await socket.SendAsync(sendBuffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }

    }
}
