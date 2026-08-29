using Microsoft.AspNetCore.SignalR;

namespace ChatSignalRCurso.Hubs
{
    public class ChatHub : Hub
    {
        public static readonly Dictionary<string, Dictionary<string, string>> Salas = new();

        public async Task EntrarSala(string sala, string usuario)
        {

            if (!Salas.ContainsKey(sala))
            {
                Salas[sala] = new Dictionary<string, string>();
            }

            Salas[sala][Context.ConnectionId] = usuario;

            await Groups.AddToGroupAsync(Context.ConnectionId, sala);
            await Clients.OthersInGroup(sala).SendAsync("MensagemSistema", $"{usuario} entrou na sala");


        }


    }
}
