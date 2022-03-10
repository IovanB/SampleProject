using SignUp.Application.Interfaces;
using SignUp.Application.UseCases;
using SignUp.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISignUpRepository, SignUpRepository>();
builder.Services.AddScoped<ISignUpForCompany, SignUpForCompany>();
builder.Services.AddScoped<ISignUpUser, SignUpUser>();
builder.Services.AddScoped<ICompanySignUp, CompanySignUp>();

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