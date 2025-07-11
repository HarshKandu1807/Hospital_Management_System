using Hospital_Management.Models;
using Hospital_Management.Services;
using Hospital_Management.Services.Iservice;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

// Add services to the container.
builder.Services.AddScoped<IPatient, PatientService>();
builder.Services.AddScoped<IDoctor, DoctorService>();
builder.Services.AddScoped<IDepartment, DepartmentService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
