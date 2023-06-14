using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//add josn file
builder.Configuration.AddJsonFile("getway.json", optional:false,reloadOnChange:true);

// add Ocelot Service
builder.Services.AddOcelot();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

// Add Ocelot Middleware in Pipeline. 
await app.UseOcelot();
app.Run();
