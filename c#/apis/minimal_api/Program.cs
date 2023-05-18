var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new Todo(Guid.NewGuid(), false, "Pedalar"));

app.Run();
