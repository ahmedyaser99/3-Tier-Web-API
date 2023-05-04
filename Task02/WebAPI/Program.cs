using BLL.Services;
using DAL.Context;
using DAL.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string txt = "hi";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Task02Context>(
                b => b.UseLazyLoadingProxies()
                .UseSqlServer("Server=.;Database=Task02WebApi;Trusted_Connection=True;")) ;

builder.Services.AddScoped<IInstructorRepository, InstructorRepo>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepo>();
builder.Services.AddScoped<IInstructorManager, InstructorManager>();
builder.Services.AddCors(o =>
{
    o.AddPolicy(txt, builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(txt);
app.UseAuthorization();

app.MapControllers();

app.Run();
