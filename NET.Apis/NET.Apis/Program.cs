using Microsoft.AspNetCore.ResponseCompression;
using NET.Apis.SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication()
                .AddPersistences(Enums.DbTypes.POSTGRE_SQL,builder.Configuration.GetConnectionString("PostgreSQL"));
builder.Services.AddSignalR();
builder.Services.AddResponseCompression(otp =>
{
    otp.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<PosHub>("/pos-hub");

app.Run();
