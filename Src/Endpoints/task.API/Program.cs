using Microsoft.EntityFrameworkCore;
using Task.Application.Models.User.Commands.CreateUser;
using Task.Domain.User.Repositories;
using Task.Infra.Contexts;
using Task.Infra.Models.User.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region IOC
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion
builder.Services.AddMediatR(c => c.RegisterServicesFromAssemblies(typeof(CreateUserCommandHandler).Assembly));

builder.Services.AddDbContext<TaskDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), t => t.MigrationsAssembly(typeof(TaskDbContext).Assembly.FullName));
});
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
