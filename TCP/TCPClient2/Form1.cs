using ChatLib2.Handlers;
using ChatLib2.Models;
using ChatLib2.Sockets;
using System.Net;

namespace TCPClient2
{
    public partial class Form1 : Form
    {
        private ChatClient _client;
        private ClientHandler? _clientHandler;

        private int RoomId => (int)nudRoomId.Value;
        private string UserName => txtName.Text;
        private string Message => txtMessage.Text;


        private void RunningStateChanged(bool isRunning)
        {
            btnConnect.Enabled = !isRunning;
            btnStop.Enabled = isRunning;
        }

        private void Connected(object? sender, ChatLib2.Events.ChatEventArgs e)
        {
            _clientHandler = e.ClientHandler;
        }

        private void Disconnected(object? sender, ChatLib2.Events.ChatEventArgs e)
        {
            _clientHandler = null;
            lbxMsg.Items.Add("������ ������ ������ϴ�.");
        }

        private void Received(object? sender, ChatLib2.Events.ChatEventArgs e)
        {
            ChatHub hub = e.Hub;
            string message = hub.State switch
            {
                ChatState.Connect => $"{hub.UserName}���� �����Ͽ����ϴ�.",
                ChatState.Disconnect => $"{hub.UserName}���� �����Ͽ����ϴ�.",
                _ => $"{hub.UserName}: {hub.Message}"
            };

            lbxMsg.Items.Add(message);
        }

        private async void btnConnect_Click_1(object sender, EventArgs e)
        {
            await _client.ConnectAsync(new ConnectionDetails
            {
                RoomId = RoomId,
                UserName = UserName,
            });
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            _client.Close();
        }


        private void TxtMessage_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _clientHandler?.Send(new ChatHub
                {
                    RoomId = RoomId,
                    UserName = UserName,
                    Message = Message,
                });
                txtMessage.Clear();
            }
        }

        public Form1()
        {
            InitializeComponent();

            _client = new ChatClient(IPAddress.Parse("127.0.0.1"), 8080);
            _client.Connected += Connected;
            _client.Disconnected += Disconnected;
            _client.Received += Received;
            _client.RunningStateChanged += RunningStateChanged;

            btnConnect.Click += btnConnect_Click_1;
            btnStop.Click += btnStop_Click_1;

            txtMessage.KeyDown += TxtMessage_KeyDown;
        }

        
    }
}
