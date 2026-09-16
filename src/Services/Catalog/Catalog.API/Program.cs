var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();

builder.Services.AddMediatR(config=>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

//add services to container
var app = builder.Build();
app.MapCarter();

//configure the http request pipeline
app.Run();
