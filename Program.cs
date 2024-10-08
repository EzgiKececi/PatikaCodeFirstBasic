using CodeFirstBasic.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//3 b�y�klerin ���nc�s�
var connectionString = builder.Configuration.GetConnectionString("default");
//appsettingste default kar��s�ndaki metni ald�

builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
