using ParkingLot.Repository;
using ParkingLot.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ParkingLotService, ParkingLotService>();
builder.Services.AddSingleton<ParkingGateService, ParkingGateService>();
builder.Services.AddSingleton<IParkingLotRepository, ParkingLotRepository>();
builder.Services.AddSingleton<IParkingGateRepository, ParkingGateRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();
