using AssignmentDay1.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Nguyen Van Tien");

app.UseLoggingMiddleware();

app.Run();