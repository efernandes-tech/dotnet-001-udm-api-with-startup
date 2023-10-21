using ApiWithStartup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. // DotNet5 => ConfigureServices()

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline. // DotNet5 => Configure()

startup.Configure(app, app.Environment);

app.Run();
