using Microsoft.EntityFrameworkCore;
using ELMSWebAPI.Models;
var builder = WebApplication.CreateBuilder(args);

string? connection=builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddController();
//builder.Services.AddSession();
//builder.Services.AddDbContext<ELMSWebAPIContext>(opt =>
   // opt.UseInMemoryDatabase("ELMS"));
   builder.Services.AddDbContext<ELMSWebAPIContext>(options =>{
    options.UseSqlServer(connection);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddCors(options => options.AddPolicy(name:"Employee",
// policy =>
// {
//     policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
// }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseCors("Employee");
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


 // "https": {
    //   "commandName": "Project",
    //   "dotnetRunMessages": true,
    //   "launchBrowser": true,
    //   "launchUrl": "swagger",
    //   "applicationUrl": "https://localhost:7190;http://localhost:5168",
    //   "environmentVariables": {
    //     "ASPNETCORE_ENVIRONMENT": "Development"
    //   }
    // },
