using MC8to10.Services.GuessIt3;
using MC8to10.Services.Magic8B;
using MC8to10.Services.RestaurantPickMe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMagic8BService, Magic8BService>();
builder.Services.AddScoped<IRestaurantPickMeService, RestaurantPickMeService>();
builder.Services.AddScoped<IGuessIt3Service, GuessItService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
