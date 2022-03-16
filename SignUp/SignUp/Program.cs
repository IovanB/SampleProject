using SignUp.Application.Interfaces;
using SignUp.Application.UseCases.GetEmail;
using SignUp.Application.UseCases.SignUpUser.SignUpUsers;
using SignUp.Application.UseCases.SignUpUsers;
using SignUp.Infrastructure.Repository;
using SignUp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISignUpRepository, SignUpRepository>();
builder.Services.AddScoped<ISignUpUser, SignUpUser>();
builder.Services.AddScoped<IGetEmailUseCase, GetEmailUseCase>();
builder.Services.AddScoped<IGetEmployeeEmail, GetEmployeeEmail>();

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
