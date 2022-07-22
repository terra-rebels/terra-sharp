using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Constants;
using TerraSharp.Client.Lcd.Args.LcdClient.Subscriptions;

namespace TerraSharp.Client
{
    public class WebSocketClient : IDisposable
    {
        public bool isConnected;
        private TimeSpan? reconnectTimeoutId;
        private string queryParams;
        private bool shouldAttemptReconnect;
        private WebSocket socket;
        private int reconnectCount;

        public Func<TendermintSubscriptionResponse<bool>> Callback { get; set; }

        public WebSocketClient(
            string url,
            int reconnectCount = LcdWebSocketClientConstants.RECONNECTION_COUNT,
            int reconnectInterval = LcdWebSocketClientConstants.RECONNECT_INTERVAL)
        {
            this.reconnectCount = reconnectCount;
            this.PrepareWebSocket();
        }

        private void PrepareWebSocket()
        {
            this.socket = WebSocket.CreateFromStream();
            this.socket.

        }

        public string MakeQueryParams(TendermintQuery query)
        {
            var queryBuilder = new StringBuilder();
        }

        public void Dispose()
        {
            this.shouldAttemptReconnect = false;
            this.reconnectTimeoutId
        }

        private void OnOpen()
        {

        }
    }

}
