using HR.LeaveManagement.Api.Middleware;
using HR.LeaveManagement.Application;
using HR.LeaveManagement.Identity;
using HR.LeaveManagement.Infrastructure;
using HR.LeaveManagement.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("all");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
