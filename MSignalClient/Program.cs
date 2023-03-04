using System.IO;
using Microsoft.AspNetCore.SignalR.Client;

const string url = "http://localhost:5154/mainHub";

await using var connection = new HubConnectionBuilder()
    .WithUrl(url)
    .Build();

await connection.StartAsync();

await foreach (var date in connection.StreamAsync<DateTime>("Streaming"))
{
    Console.WriteLine(date);
}
