using Core.Common.Util.Helper.Autenticacion;
using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Internal;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();

//Configuración JWT;
JwtHelper.ConfigurarServicioJWT(builder);
//Configurar Settings Helper
SettingsHelper.ObtenerJsonAppSetings(builder.Configuration);
LogHelper.ConfigurarServicio(builder);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
