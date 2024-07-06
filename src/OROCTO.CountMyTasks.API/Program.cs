using OROCTO.CountMyTasks.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using OROCTO.CountMyTasks.Service.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var countMyTasksDbConnectionString = builder.Configuration.GetConnectionString("CountMyTasksDatabase");
builder.Services.AddDbContextPool<CountMyTasksServiceContext>(options => options.UseSqlServer(countMyTasksDbConnectionString));

//Custom Middlewares
builder.Services.AddAutoMapper(typeof(MappingProfile));

//builder.Services.AddScoped<>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
