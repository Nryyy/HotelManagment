using BlazorAppHotelManagment.Data;
using HotelManagmentLogic.ApplicationContext; // Ensure this namespace is correct
using HotelManagmentLogic.UnitOfWorkManagment;
using HotelManagmentLogic.Services.Commands;
using HotelManagmentLogic.Services.Querys;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;
using HotelManagmentLogic.Interfaces.IRepoository.Commands;
using HotelManagmentLogic.Repositories.Querys;
using HotelManagmentLogic.Repositories.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Register the DbContext with the dependency injection container
builder.Services.AddDbContext<HotelDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelDB")));

// Register other services
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<GuestCommandService>();
builder.Services.AddScoped<GuestQueryService>();

builder.Services.AddScoped<RoleCommandService>();
builder.Services.AddScoped<RoleQueryService>();

builder.Services.AddScoped<EmployeeCommandService>();
builder.Services.AddScoped<EmployeeQueryService>();

builder.Services.AddScoped<PaymentStatusCommandService>();
builder.Services.AddScoped<PaymentStatusQueryService>();



builder.Services.AddScoped<IGuestQueryRepository, GuestQueryRepository>();
builder.Services.AddScoped<IGuestCommandRepository, GuestCommandRepository>();

builder.Services.AddScoped<IRoleCommandRepository, RoleCommandRepository>();
builder.Services.AddScoped<IRoleQueryRepository, RoleQueryRepository>();

builder.Services.AddScoped<IEmployeeCommandRepository, EmployeeCommandRepository>();
builder.Services.AddScoped<IEmployeeQueryRepository, EmployeeQueryRepository>();

builder.Services.AddScoped<IPaymentStatusCommandRepository, PaymentStatusCommandRepository>();
builder.Services.AddScoped<IPaymentStatusQueryRepository, PaymentStatusQueryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
