using ApplicationManagment.ApplicationContext;
using ApplicationManagment.Interfaces.IRepoository.Commands;
using ApplicationManagment.Interfaces.IRepoository.Querys;
using ApplicationManagment.Repositories.Commands;
using ApplicationManagment.Repositories.Querys;
using ApplicationManagment.Services.Commands;
using ApplicationManagment.Services.Querys;
using ApplicationManagment.UnitOfWorkManagment;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ��������� DbContext
builder.Services.AddDbContext<HotelDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelDB")));

// ��������� ������ ��� ������ � ������
builder.Services.AddScoped<GuestCommandService>();
builder.Services.AddScoped<GuestQueryService>();
builder.Services.AddScoped<IGuestQueryRepository, GuestQueryRepository>();
builder.Services.AddScoped<IGuestCommandRepository, GuestCommandRepository>();

// ��������� UnitOfWork, ���� �������
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// ��������� ������ ��� Web API
builder.Services.AddControllers();

// ���� ������, ���� �������
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
