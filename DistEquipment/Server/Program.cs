using DistEquipment.Server.Data;
using DistEquipment.Server.Mapper;
using DistEquipment.Server.Services;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDBcontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AbbDBcontext")));
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(typeof(AppMapperProfile));

builder.Services.AddScoped<IDataProduct,DataProduct>();
builder.Services.AddScoped<IDataCategory, DataCategory>();
builder.Services.AddScoped<IDataState, DataState>();
builder.Services.AddScoped<IDataSolvent, DataSolvent>();
builder.Services.AddScoped<IDataWork, DataWork>();
builder.Services.AddScoped<IDataNews, DataNews>();
builder.Services.AddScoped<IEmailService, EmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");


app.Run();
