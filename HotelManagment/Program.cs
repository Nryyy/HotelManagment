using ApplicationManagment.Interfaces.IRepoository.Commands;
using ApplicationManagment.Interfaces.IRepoository.Querys;
using ApplicationManagment.Repositories.Commands;
using ApplicationManagment.Repositories.Querys;
using ApplicationManagment.Services.Commands;
using ApplicationManagment.Services.Querys;
using ApplicationManagment.UnitOfWorkManagment;
using HotelManagment.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<HotelManagment.Application.HotelDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelDB")));


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<GuestCommandService>();
builder.Services.AddScoped<GuestQueryService>();
builder.Services.AddScoped<IGuestQueryRepository, GuestQueryRepository>();
builder.Services.AddScoped<IGuestCommandRepository, GuestCommandRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
