using CodeFirstBasic.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//3 büyüklerin üçüncüsü
var connectionString = builder.Configuration.GetConnectionString("default");
//appsettingste default karþýsýndaki metni aldý

builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
