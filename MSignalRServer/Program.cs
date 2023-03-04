using MSignalRServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add SignalR services to the container.
builder.Services.AddSignalR();

var app = builder.Build();
// Hub route
app.MapHub<MainHub>("/mainHub");

app.MapGet("/", () => "Hello World!");

app.Run();
