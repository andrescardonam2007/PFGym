using Gym.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ── Controllers ──
builder.Services.AddControllers();

// ── Swagger ──
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ── DbContext (InMemory) ──
builder.Services.AddDbContext<GymDbContext>(options =>
    options.UseInMemoryDatabase("GymDb"));

// ── AutoMapper ──
builder.Services.AddAutoMapper(typeof(Program));

// ── Build ──
var app = builder.Build();

// ── Middleware Pipeline ──
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirigir raíz a Swagger
app.MapGet("/", () => Results.Redirect("/swagger"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();