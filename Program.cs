using MinhaPrimeiraAPI;

var builder = WebApplication.CreateBuilder(args)
    .UseStartup<Startup>();

/*var startup = new Startup(builder.Configuration);
// Método de configuração do serviço
startup.ConfigurationServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);
app.Run();*/
