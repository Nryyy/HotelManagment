using BlazorAppHotelManagment.Data;
using HotelManagmentLogic.ApplicationContext; // Ensure this namespace is correct
using HotelManagmentLogic.UnitOfWorkManagment;
using HotelManagmentLogic.Services.Commands;
using HotelManagmentLogic.Services.Querys;
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

builder.Services.AddScoped<PaymentMethodCommandService>();
builder.Services.AddScoped<PaymentMethodQueryService>();

builder.Services.AddScoped<BookingPaymentCommandService>();
builder.Services.AddScoped<BookingPaymentQueryService>();

builder.Services.AddScoped<RoomStatusCommandService>();
builder.Services.AddScoped<RoomStatusQueryService>();

builder.Services.AddScoped<RoomcategoryCommandService>();
builder.Services.AddScoped<RoomcategoryQueryService>();

builder.Services.AddScoped<RoomCommandService>();
builder.Services.AddScoped<RoomQueryService>();

builder.Services.AddScoped<BookingStatusCommandService>();
builder.Services.AddScoped<BookingStatusQueryService>();

builder.Services.AddScoped<BookingCommandService>();
builder.Services.AddScoped<BookingQueryService>();

builder.Services.AddScoped<EmploteeActionQueryService>();
builder.Services.AddScoped<EmployeeActionCommandService>();

builder.Services.AddScoped<StayHistoryCommandService>();
builder.Services.AddScoped<StayHistoryQueryService>();

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
