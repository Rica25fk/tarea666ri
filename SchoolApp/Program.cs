using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Context;
using School.Infrastructure.Repositories;
using School.Domain.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

var app = builder.Build();


app.MapControllers();

app.Run();
