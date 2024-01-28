using artificially_infused.Controllers.game;
using artificially_infused.Services;
string startificiallyinfuseddev = "DefaultEndpointsProtocol=https;AccountName=startificiallyinfuseddev;AccountKey=QShFG5XUWa5f6OwqJ/UzxtnIORBsWZxylC1vP9xa4hskWJ++EYDRGNTgqGFhIC3GUtHRqOBY0c0K+AStqZOQag==;EndpointSuffix=core.windows.net";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<GameService, GameService>();
builder.Services.AddScoped<GameRepository>(x => new GameRepository(startificiallyinfuseddev));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
            builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
